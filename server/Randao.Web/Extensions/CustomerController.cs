�}�
  �   ����$-_�u
���cd��Ɔ���P���R���ڲHG�L c����D���j.6�pH���a�:e0Ӕ���P�+x�@�B��(���Q�n�>�ݱ�c���q��AOzH�Pf�%5�^s��d�/(�=�'d&�Q����C꾏14�����2���@�/ ��D/z�}�9Y᝴��%&��)�����ϧ������B/�7���ԡ���m��h�}���v��$|�x6 ���{�I�
��q�W�46��R4�E8x������������_���GG�f��6OI�H�Tb�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�lD&�{�����c�.{��d_
��t��3�ik2r�0kfZ�x7e��$��^��6�-��R��������TZ�o�� 5\dL!|K�j���"ʳ}tc��,�u�Su�ޣ��FL�Z=�O}�~ ������\�,LɈ�d�Ȃ�.�#��`�P�iM:1�X�$�0�Qϲ�)NE�;�!�[ك�O��Ӕߡ�lB�o��R��jH70i|��*C\�/#u�{5=�����0�$�z�
�j2�}�o���bϨN@}�r�2&�R�� ���ʰ��i�����Ѐ���,	��lnN���Gk�h*7C�X��LI�kB�ʸ���b0	<�P��g�2-��ѐg�9��Ž�ٿg<ޏ���g�:+i@;B}����w�/����2.F":�J�ש1!�9�VPȉ����^-?�&5Ԅ��r���B��G��S�Fa����c�[�dơx��� ��j���7Ƙ�Д-�������]7()�<�J� �"�9.Response;

			response.ContentType = !String.IsNullOrEmpty(ContentType) ? ContentType : "application/json";

			if (ContentEncoding != null)
			{
				response.ContentEncoding = ContentEncoding;
			}

			if (Data != null)
			{
				response.Write(JSONHelper.Encode(Data));
			}
		}
	}
}