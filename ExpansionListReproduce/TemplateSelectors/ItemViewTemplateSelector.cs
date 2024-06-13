using ExpansionListReproduce.ViewModels;

namespace ExpansionListReproduce.TemplateSelectors;

public class ItemViewTemplateSelector : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return DefaultTemplate;
    }
}