import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArticleListComponent } from './components/article-list/article-list.component';
import { ArticleCreateComponent } from './components/article-create/article-create.component';
import { ArticleReadComponent } from './components/article-read/article-read.component';
import { ArticleUpdateComponent } from './components/article-update/article-update.component';

const routes: Routes = [{
    path: '',
    component: ArticleListComponent
  },
  {
    path: 'create',
    component: ArticleCreateComponent
  },
  { 
    path: ':id',
    component: ArticleReadComponent
  },
  { 
    path: ':id/edit',
    component: ArticleUpdateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
