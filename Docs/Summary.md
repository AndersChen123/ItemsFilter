## ������
���������� *ItemsFilter* ��������� ������ � ���������� ������������� ������������� �������� 
����������������� ���������� ��� ���������� ������������ ��������� (������� ������). 

� ������ ���������� ������ ������� Control `ColumnFilter`, ����������� ���������� 
������� ������ � ��������� ������� � ������� ����� (`int`, `real`, `string`, `bool`, `enum`, `object` � �.�.). 
� ����������� �� ���� ��������, `ColumnFilter` ���������� ��������� ����� ��������:
<table>
    <tr>
        <td><b>Property type</td>
        <td><b>Filters</td>
    </tr>
    <tr>
        <td>int, real, long etc.</td>
        <td>EqualFilter, LessOrEqualFilter, GreaterOrEqualFilter, RangeFilter</td>
    </tr>
    <tr>
        <td>IComparable</td>
        <td>EqualFilter, LessOrEqualFilter, GreaterOrEqualFilter, RangeFilter</td>
    </tr>
    <tr>
        <td>String</td>
        <td>EqualFilter, StringFilter</td>
    </tr>
    <tr>
        <td>Bool</td>
        <td>EqualFilter</td>
    </tr>
    <tr>
        <td>Object</td>
        <td>EqualFilter</td>
    </tr>
</table>

��������� `ColumnFilter` � `DataGrid` � ��������� ��� �������� ���� �������� ����� �����
� �������������� ��� ��������� ������������� ����. 

�������� ���������������� ��������, ����������� ������������������ ������� ����������, 
� ��������� �� � ���������������� ��������� ����� �������������� � ��������� ����� ����.

**Enjoy**!

[�����](Examle7.CustomersView.md "���������� ��������� � TreeView. (CustomersView)") <<
[����������](Readme.md)
