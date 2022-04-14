### 7.	���������� ��������� � TreeView. (CustomersView)
����� *CustomersView.xaml* ���������� � `TreeView` ���������� ������� � ������� `Customers`.
`TreeView`  ����� 2 ������ ����������� (�� ������� � �� �������) � ����� ������� ����������.

��������� ������� ������������ � ���� ������������ ��������� `CountryCustomersTreeItem`,
������� ��������� ���������:
![CountryCustomersTreeItem](Picture/Pic9.gif "���.9")
#### ��� ����������� � ����
���������� ����� `CustomersTreeFilterInitializer` � ������ ��������� �������� - 
��. ����� � ����� *Nortwind.Sample.net6/View/CustomersTreeFilter*.

� ����� *CustomersView.xaml* � ������� ��� `TreeView` ��������� ������� ���������� `FilterControl` 
� ������������� ��� ���� ��������� ������������� ������� `CustomersTreeFilterInitializer`:

    <bsFilter:FilterControl Key="Country"
                            Grid.Row="1"
                            Grid.Column="1"
                            Margin="3"
                            ParentCollection="{TemplateBinding ItemsSource}">
        <bsFilter:FilterControl.FilterInitializersManager>
            <bsFilter:FilterInitializersManager>
                <vw:CustomersTreeFilterInitializer/>
            </bsFilter:FilterInitializersManager>
        </bsFilter:FilterControl.FilterInitializersManager>
    </bsFilter:FilterControl>

������.
#### ���������:
![CustomersView](Picture/Pic10.gif "���.10")
#### ��� ��� ���������
`FilterControl`, ���������� � ������ �������, ������ ��� ���������� ��� � �������� ���������,
������������ ��������, ��� � �� ��������� ���������� 
(�������� `CountryCustomersTreeItem.Cities` � `CityCustomersTreeItem.Customer`). ��� ���������� 
�������� � ���������� ����������� ��������� ��� ������ �������� � `CountriesTreeFilter`, 
`CitiesTreeFilter` � `CustomersTreeFilter` � �� ������ �� ������ ������� ����������. 
������� ������������� ������� �������� ��������� ������  `CountriesTreeFilter`. 
��� ����������� ��������� `CountriesTreeFilter` ��������� ������������ ����������� 
`CountryCustomersTreeItem` � ��������� ������� ��� ������ ��������� ���������
`CityCustomersTreeItem`, ���������� � �������� `Cities`. ������ �� ���������� ������� 
����������� ��� �������� ������� ������� � ������������ ������� ���������� *IsMatch*. 
����������� ������ ������������ �� ������ ����������� ������� `CitiesTreeFilter`.

[�����](Examle6.OrdersView.md "���������� ��������� � ComboBox. (OrdersView)") <<
[����������](Readme.md) >>
[������](Summary.md "� ����������. ������ � �� ��������")