�}D
  f   ��Uo�FV_�u
���cL�j�uʝ��IpR\�ox.B��G���¨��s�Di����	�9WN����Y�W��-�_V|d��D�3Sb�1�z�t�S4�5� xo�6�/9��o!Ql��;�1JR�|q�" ����_n��!��!K�^���H�Q�w��,�����B9����_�7�L�rw >�n �3pâ���VyO�9�DG�km�;]����d�K2���G�U�$���O��O�ͺys9ȟ�P8*�uEO_`�9����Dg�N�^-�A��}(���z��_t�b�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�l�-	>MX�Ah!ݞ5���O�vX#G�G�K8�.p�'�k�f����C��Y]/���qq��Я����"�<j��=I�1�飃�s��?���Qd�`8R�l�g�!1��'sh:6��!�=)���jE5�]�����`��c����Mq4	d��ɯ�Hj�԰{"�lq-�ky����^�s �n�TGX��&��%��u<+�@�Mf;���D5d���u۶��&������w$E
�K��&�o�l>�}s5�-�}P ���دW\ȥa�.L�I�L������pF���4�ߞpFu�5�`��C�x�r���jֶp3��?�����R�_���l��H�=��\�y����$�[&\���Z��[�4E3�|�zX�?FƎ��V��W(B����JJ�/���Ay�D����XA��Drf�'��X''��.�m"���dY���ݛ�f�L��н#<�5ڑ�lL1��LM����B��iȼ�?�~?g�Id,ParentId,parentIdList,CategoryName,CategoryOtherName,Sequence,PostTime,UpdateTime,
						   Description,IsWapShow FROM SA_ArticleCategory WHERE IsWapShow=1 ORDER BY Sequence ASC";

			var _list = new List<ArticleCategoryDataContract>();

			using (var dr = SqlHelper.ExecuteReader(SqlHelper.GetConnSting(), CommandType.Text, sql))
			{
				_list = EntityHelper.GetList<ArticleCategoryDataContract>(dr);
			}

			return _list;
		}
	}
}
