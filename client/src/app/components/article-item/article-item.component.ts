import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Article } from '../../shared/types/article';
import { ArticleService } from '../../services/article.service';

@Component({
  selector: 'article-item',
  templateUrl: './article-item.component.html',
  styleUrls: ['./article-item.component.css']
})
export class ArticleItemComponent {
  @Input() article!: Article;

  @Output("refresh") parentFun: EventEmitter<any> = new EventEmitter();

  constructor(private readonly employeeService: ArticleService,
    private route: ActivatedRoute,
    private router: Router){
  }

  onDelete(id?: string): void{
    this.employeeService.delete(id!)
    .subscribe({
      next: () => {
        this.parentFun.emit();
      },
      error: (err) => {
        alert('Error');
      },
    });
  }
}
