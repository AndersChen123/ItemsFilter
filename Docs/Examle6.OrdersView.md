### 6.	���������� ��������� � ComboBox. (OrdersView)
� ����� `OrdersView` ������ � ������ ����� �������� � ������� ������������� ������ 
�������� ���������� `ComboBox`. ��� ������, �� ���������� ���� ����� *Northwind* �������,
� ��������� ��������� �������� �������� ������ �� ������: �� ������������ �����, 
�� ����� ����������� ����, �� ��������������. � ����������� *ItemsFilter* ��� ��������.

#### ��� ����������� � ����
������� ���� ������� � ������������������ ������ `CustomersComboBoxFilter` 
� ��� ������������� `CustomersComboBoxFilterInitializer`:

File *CustomersComboBoxFilter.cs*:

    [View(typeof(StringFilterView))]
    // Define specialized filter for CustomersComboBox.
    public sealed class CustomersComboBoxFilter: StringFilter, IFilter {
        private static StringBuilder sb = new StringBuilder();
        internal CustomersComboBoxFilter()
        // To search for combine the values of several properties.
            : base(item => 
            {
                Customer customer = (Customer)item;
                sb.Clear();
                sb.Append(customer.City);
                sb.Append(',');
                sb.Append(customer.Code);
                sb.Append(',');
                sb.Append(customer.ContactName);
                sb.Append(',');
                sb.Append(customer.Country);
                sb.Append(',');
                sb.Append(customer.Name);
                sb.Append(',');
                sb.Append(customer.Region);
                return sb.ToString();
            }) {}
    }

File *CustomersComboBoxFilterInitializer.cs*:

    class CustomersComboBoxFilterInitializer:FilterInitializer {
        public override BolapanControl.ItemsFilter.Model.Filter NewFilter(
                FilterPresenter filterPresenter, 
                object key) {
            if (key != null && 
                filterPresenter.CollectionView.SourceCollection is IEnumerable<Customer>) {
                	return new CustomersComboBoxFilter();
                }
            return null;
        }
    }

� ������ �������� ���������� `ComboBox` ������ ����� ��������� ������ �  ����������� ��� � `ItemsSource`:

File *CustomerComboBoxStyle.xaml*:

    <Style x:Key="ComboBoxStyle" TargetType="{x:Type ComboBox}">
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="{x:Type ComboBox}">
                        <Grid x:Name="MainGrid" SnapsToDevicePixels="true">
                    ...
                    <bsFilter:FilterControl Key="CustomerAnyFieldFilter"
                                     ParentCollection="{TemplateBinding ItemsSource}">
                        <bsFilter:FilterControl.Resources>
           	            <Style BasedOn="{StaticResource CustomerComboBox_StringFilterStyle}" 
				            TargetType="{x:Type bsFilter:StringFilterView}" />
                        </bsFilter:FilterControl.Resources>
                        <bsFilter:FilterControl.FilterInitializersManager>
                            <bsFilter:FilterInitializersManager>
                                    <vm:CustomersComboBoxFilterInitializer />
                            </bsFilter:FilterInitializersManager>
                        </bsFilter:FilterControl.FilterInitializersManager>
                    </bsFilter:FilterControl>
                    ...

����������� ����������� ������� ����� ����� `�ustomerComboBox_StringFilterStyle`.
������.
#### ��� ������������
� ����� ���������� ���������� ����� � �������� `ComboBox`.
���� *OrdersView.xaml*:

    <ComboBox x:Name="customerComboBox"
       ItemsSource="{Binding Customers,
                                    Source={StaticResource Workspace}}"
              SelectedItem="{Binding Customer,
                                     Converter={StaticResource NullToUnsetValueConverter}}"
              Style="{DynamicResource ComboBoxStyle}" />
#### ��� ��� ��������
![OrdersView](Picture/Pic8.gif "���.8")

[�����](Examle5.OrdersView.md "���������� ��������� � ���������������� �������� ����������. (OrdersView)") <<
[����������](Readme.md) >>
[������](Examle7.CustomersView.md "���������� ��������� � TreeView. (CustomersView)")
