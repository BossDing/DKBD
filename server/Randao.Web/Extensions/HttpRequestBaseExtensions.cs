�}%
  �   �Jn��B�_�u
���c��x�_б��0&�K�ŠJ�{˒ͤ͞�i#0\&������ϡ�vl�����C���gd��>��'��d�,�ZW|�������x��M�l�-i����Q�5Uz�0�/\Q�)�Z7_%�4���1k���-�Qת����)��OB�?�S�}ȹ����?f�f/�������i�s[U���ϩ��
��ʃ�5����w��kMp���&6z n9�e�)�j��9pD��Ĺ��v�N���")EW���C��KW�ˏ$��aq"آ��z��_t�b�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�uest request)
		{
			if (request.ServerVariables["HTTP_VIA"] != null)
			{
				return request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(new char[] { ',' })[0];
			}
			else
			{
				return request.ServerVariables["REMOTE_ADDR"];
			}
		}
	}
}