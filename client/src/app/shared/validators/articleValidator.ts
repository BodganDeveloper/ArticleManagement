import { Validator } from 'fluentvalidation-ts';
import { Article } from '../types/article';

export class ArticleValidator extends Validator<Article> {
    constructor() {
      super();
  
      this.ruleFor('title').notEmpty();

      this.ruleFor('content').notEmpty();
    }
  }