�}K
  �   v]�����_�u
���cD
���1n�h�^����I�"�p�}.�m.��QmQ�RR���	� �Ј�~�.�e����%|3Hu�g�'L�Bs�i�Ϧg�!�d�,�0��=%=Ap�D"��Vա�\=�A:-J	���,�!*���K-5���{�l�Pi��o��A
�p�E�*�im��؀��сqd� Fѽr]��B(�i�簌��ͺ��0�a\�Y��} �����H�LI��`V�_���$f~��ڂ�Є9֢P\O�noJ�Y�&�_�)�<}�����5�՝��6eٽb�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�builder.RegisterControllers(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinderProvider();
			builder.RegisterFilterProvider();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
		}
	}
}