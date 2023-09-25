import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

import { Article } from '../../shared/types/article';
import { ArticleService } from '../../services/article.service';
import { ArticleValidator } from '../../shared/validators/articleValidator';

@Component({
  selector: 'article-create',
  templateUrl: './article-create.component.html',
  styleUrls: ['./article-create.component.css']
})
export class ArticleCreateComponent {
  articleForm = this.formBuilder.group({
    title: new FormControl("", { nonNullable: true }),
    content: new FormControl("", { nonNullable: true }),
  });

  constructor(private formBuilder: FormBuilder,
            private articleService: ArticleService,
            private router: Router){
  }

  onSubmit(): void {
    const validator = new ArticleValidator();

    const newArticle: Article = this.articleForm.value;
    
    const errors = validator.validate(newArticle);

    console.log(errors);

    if (Object.keys(errors).length === 0){
      this.articleService.create(newArticle)
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
