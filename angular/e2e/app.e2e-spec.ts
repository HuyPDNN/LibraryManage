import { LabraryManageTemplatePage } from './app.po';

describe('LabraryManage App', function() {
  let page: LabraryManageTemplatePage;

  beforeEach(() => {
    page = new LabraryManageTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
