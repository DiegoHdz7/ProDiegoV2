import { ProDiegoV2TemplatePage } from './app.po';

describe('ProDiegoV2 App', function() {
  let page: ProDiegoV2TemplatePage;

  beforeEach(() => {
    page = new ProDiegoV2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
