### ������������� �������� �������� ���������� FilterDataGrid (EmployeesView).
����� �������� ������� ������ � ��������� DataGrid ��� ������ ������, 
������ ��������� � ����� `FilterDataGrid`, ������� ���������� �� ������������ `DataGrid` ������ �����
� � ������ ��������� ������� ��� ������� `ColumnFilter`:
#### ��� ��� ��������
![DataGrid column filter](Picture/Pic1.gif "���.1")
#### ��� ������������
    <UserControl x:Class="Northwind.NET.Sample.View.EmployeesView"
                 ...
                 xmlns:bsFilter="http://schemas.bolapansoft.com/xaml/Controls/ItemsFilter"
                 ...>
    <bsFilter:FilterDataGrid  ItemsSource="{Binding}" ... />
    </UserControl>
#### ��� ��� ��������
������� ���������� `ColumnFilter` ������� � ��������� ������� `DataGrid`. ��� �������� `ColumnFilter`
��������� �������� �������� ��� �������, � ������� �� ����������, � ��������� ������������� ���������, ����������� � ������������� `DataGrid`
����� �������� `DataGrid.ItemsSource`. ������ �� ����������� ����������, ����������� ������ ��������,
���������� ��� �������, � ������������ � `ColumnFilter`. 
���� ��� ������� ���������� � �������� ������� ���������� (��������, ��� `DataGridTemplateColumn`),
�������� `ColumnFilter` ����� �������� � ������� ��������������� ��������
`bsFilter:ColumnFilter.BindingPath="<���_��������_��������_���������>"`.


[�����](ALittleBackground.md "������� �����������: ����������� ��� �������������. ������ ����������."). <<
[����������](Readme.md) >>
[������](Examle2.CategoriesView.md "��������� � DataGrid ����� ����� (CategoriesView)")