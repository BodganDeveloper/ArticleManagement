import { Component, OnInit} from '@angular/core';

import { ArticleService } from '../../services/article.service';
import { Article } from '../../shared/types/article';

@Component({
  selector: 'article-list',
  templateUrl: './article-list.component.html',
  styleUrls: ['./article-list.component.css'],
})
export class ArticleListComponent implements OnInit{
  articles!: Article[];

  constructor(
    private readonly articleService: ArticleService,
  ) {}
  
  ngOnInit(): void {
    this.articleService.getAll()
    .subscribe(data => {
      this.articles = data;
    })
  }
}
