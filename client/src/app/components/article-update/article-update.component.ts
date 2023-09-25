import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { Article } from '../../shared/types/article';
import { ArticleService } from '../../services/article.service';
import { ArticleValidator } from '../../shared/validators/articleValidator';

@Component({
  selector: 'app-article-update',
  templateUrl: './article-update.component.html',
  styleUrls: ['./article-update.component.css']
})
export class ArticleUpdateComponent {
  id!: string;
  loading: boolean = true;
  articleNotFound: boolean = false;
  
  articleForm = this.formBuilder.group({
    title: new FormControl("", { nonNullable: true }),
    content: new FormControl("", { nonNullable: true }),
  });

  constructor(private formBuilder: FormBuilder,
            private articleService: ArticleService,
            private route: ActivatedRoute,
            private router: Router){
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') as string;

    this.articleService.getById(this.id)
    .subscribe({
      next: (data) => {
        console.log(data);
        this.loading = false;
        this.articleForm.setValue({title:data.title!, content:data.content!});
      },
      error: (err) => {
        this.loading = false;
        this.articleNotFound = true;
      },
    })
  }

  onSubmit(): void {
    const validator = new ArticleValidator();

    const newArticle: Article = this.articleForm.value;
    
    const errors = validator.validate(newArticle);

    console.log(errors);

    if (Object.keys(errors).length === 0){
      this.articleService.update(this.id!, newArticle.title!, newArticle.content!)
      .subscribe({
        next: () => this.router.navigateByUrl(''),
        error: (err) => {
          alert('Error');
        },
      });;
    }
    else{
      alert('Input Correctly!');
    }
  }
}
