public class OEmbedPickerValueConverter
    : PropertyValueConverterBase
{
    public override bool IsConverter(PublishedPropertyType propertyType) { }

    public override Type GetPropertyValueType(PublishedPropertyType propertyType) { }

    public override bool? IsValue(object value, PropertyValueLevel level) { };

    public override object ConvertIntermediateToObject(
            IPublishedElement owner,
            PublishedPropertyType propertyType,
            PropertyCacheLevel referenceCacheLevel,
            object inter,
            bool preview)
    {
    }
}