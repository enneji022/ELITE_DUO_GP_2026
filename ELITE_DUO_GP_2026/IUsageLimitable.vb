Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: IUsageLimitable
' **************************************************************************************************

Public Interface IUsageLimitable
    ReadOnly Property MaxUsableAmount As Integer
    Function CanUseMore(Amount As Integer) As Boolean
End Interface
