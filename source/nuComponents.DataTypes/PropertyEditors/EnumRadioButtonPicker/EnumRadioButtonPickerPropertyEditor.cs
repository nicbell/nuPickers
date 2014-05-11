﻿
namespace nuComponents.DataTypes.PropertyEditors.EnumRadioButtonPicker
{
    using ClientDependency.Core;
    using Umbraco.Core.PropertyEditors;
    using Umbraco.Web.PropertyEditors;

    // EDITOR UI
    [PropertyEditor("enumRadioButtonPicker", "nuComponents: Enum RadioButton Picker", "App_Plugins/nuComponents/DataTypes/Shared/RadioButtonPicker/RadioButtonPickerEditor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Css, "App_Plugins/nuComponents/DataTypes/Shared/RadioButtonPicker/RadioButtonPickerEditor.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "App_Plugins/nuComponents/DataTypes/Shared/RadioButtonPicker/RadioButtonPickerEditorController.js")]

    // RESOURCES
    [PropertyEditorAsset(ClientDependencyType.Javascript, "App_Plugins/nuComponents/DataTypes/Shared/Picker/PickerResource.js")]

    // CONFIG
    [PropertyEditorAsset(ClientDependencyType.Javascript, "App_Plugins/nuComponents/DataTypes/Shared/EnumDataSource/EnumDataSourceConfigController.js")]
    public class EnumRadioButtonPickerPropertyEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new EnumRadioButtonPickerPreValueEditor();
        }
    }
}