import { Component, Input } from '@angular/core';
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

  constructor(private readonly employeeService: ArticleService,
    private route: ActivatedRoute,
    private router: Router){
  }

  onDelete(id?: string): void{
    console.log(id);
    this.employeeService.delete(id!)
    .subscribe({
      next: () => this.router.navigateByUrl(''),
      error: (err) => {
        alert('Error');
      },
    });;
  }
}
