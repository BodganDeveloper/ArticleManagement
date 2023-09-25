import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { ArticleService } from '../../services/article.service';
import { Article } from '../../shared/types/article';

@Component({
  selector: 'app-article-read',
  templateUrl: './article-read.component.html',
  styleUrls: ['./article-read.component.css']
})
export class ArticleReadComponent {
  article!: Article;
  id!: string;

  constructor(
    private readonly articleService: ArticleService,
    private route: ActivatedRoute,
    private router: Router
  ) {}
  
  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') as string;

    this.articleService.getById(this.id)
    .subscribe({
      next: (data) => {
        this.article = data;
      },
      error: (err) => {
        this.router.navigateByUrl('');
      },
    })
  }

}
