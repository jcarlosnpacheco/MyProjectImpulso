import { MyProjectImpulsoTemplatePage } from './app.po';

describe('MyProjectImpulso App', function() {
  let page: MyProjectImpulsoTemplatePage;

  beforeEach(() => {
    page = new MyProjectImpulsoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
