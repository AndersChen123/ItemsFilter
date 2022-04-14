### ���������� ��������� � ���������������� �������� ����������. (OrdersView)
��� ���� ������� ����, `FilterPresenter` �� ��������������� � ��������� ���������� `ItemsControl`
���������������. ��� ��������� `FilterControl` � ���������������� ������� ���������� ����������, 
����� `FilterControl` ���  ��������� � ���� �� ������������� ���������, ������� ���������� 
��� ������� ����������. ��� �������������� ������������� �������� ������� ����������,
����� ��� ������� ���������� ����������� ������� ��������� ������������ `CollectionView`.

����� *OrdersView.xaml* ������������ ����� ���������������� ������� ����������, 
��������� ���������� LINQ ������� � ���� � �������������� `CollectionView`. 
��� ���������� ������� ���������� � ����� �������� `ColumnFilter`.
#### ��� ������������
    <bsFilter:ColumnFilter Key="Employee"
        ParentCollection="{Binding DataContext.OrdersView,
            ElementName=LayoutRoot}">
    </bsFilter:ColumnFilter>
#### ��� ��� ��������
![OrdersView](Picture/Pic7.gif "���.7")

[�����](Examle4.ProductsView.md "������������� ������������� ��������� c �������� � ���������� ������. (ProductsView)") <<
[����������](Readme.md) >>
[������](Examle6.OrdersView.md "���������� ��������� � ComboBox. (OrdersView)")