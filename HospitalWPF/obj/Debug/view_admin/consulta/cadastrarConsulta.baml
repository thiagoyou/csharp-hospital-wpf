   M S B A M L   `   `   `  ����F  BHospitalWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:HospitalWPF.view_admin.consultaHospitalWPF.view_admin.consulta  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   7    1HospitalWPF.view_admin.consulta.cadastrarConsulta   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:HospitalWPF.view_admin.consulta     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   .s&clr-namespace:System;assembly=mscorlib  5   	     � Title$  Realizar Consulta��5
   	   $	��300��6#   $	��600��60   .��5      � .+�5   
   �� -   5         ��Name$ 	btnSalvar��5      $��Salvar��6$   $
��Left=�65   $��	20,0,0,20q�6P   $��Bottom=�6c   $	��120��6~   $��50��6�   6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $��Right=�69   $��	0,0,20,20q�6U   $��Bottom=�6h   $	��120��6�   $��50��6�   6�   �� 5   
   $��	Paciente:��6   $
��Left=�6$   $��	20,24,0,0q�6?   $	��Top=�6R   �� 5   
   $��Médico:��6   $
��Left=�6"   $��	20,50,0,0q�6=   $	��Top=�6P   �� 5   
   $��Agendamento:��6   $
��Left=�6'   $��310,105,0,0q�6B   $	��Top=�6W   �� 5   
   $
��Data��6   $
��Left=�6   $��	20,81,0,0q�6:   $	��Top=�6M   �� 5   
   $��Valor��6   $
��Left=�6    $��
20,105,0,0q�6;   $	��Top=�6O   �� 5   
   -   5         ��Name$ 
cbPaciente��5      $
��Left=�6'   $��136,26,-280,0q�6B   $	��Top=�6Y   $	��436��6q   ��6}   �� *	Pacientes+ �� SelectedValue 6�   �� *PacienteSelecionado+�� 5   
   -   5        $ cbMedico��5      $
��Left=�6%   $��
136,54,0,0q�6@   $	��Top=�6T   $	��436��6l   ��6x   �� *	Medicos+ 6�   �� *MedicoSelecionado+(  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateData��5      $
��Left=�6'   $��
136,79,0,0q�6B   $	��Top=�6�   $	��436��6�      SelectedDate 6W   ��  �� Path$ Consulta.Data�6�   �� 5   
   -   5        $ cbAgendamento��5      $
��Left=�6*   $��431,109,0,0q�6E   $	��Top=�6Z   $	��141��6r   ��6~   �� *Agendamentos+ 6�   �� *AgendamentoSelecionado+%  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ txtValor��5   M      Mask$ 000,00��6   4  .Xceed.Wpf.Toolkit.Primitives.ValueRangeTextBox	   ValueDataType"	 ��6+   $
��Left=�6_   $��23��6z   $��136,109,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��169��6�   5      5      