'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ordendetalle
    Public Property detord_id As Integer
    Public Property detord_idproducto As Nullable(Of Integer)
    Public Property detord_ordennumero As Nullable(Of Integer)
    Public Property detord_precio As String
    Public Property detord_cantidad As String
    Public Property detord_descuento As String
    Public Property detord_total As String
    Public Property detord_tamano As String
    Public Property detord_color As String
    Public Property detord_fechaenvio As String

    Public Overridable Property ordenes As ordenes
    Public Overridable Property producto As producto

End Class