�}�
  c   9$>���u_�u
��L�cD�Æ誥�I�D�i+6��8٢�d�� �W������v5��[�WU���q�����|�I�Cs��oTO��RqY�Y�k�0�ג	����s��f̩[�5�yN�����]*}i���IPBc������
�M�h)���|���m��Y��T�CY�P�����}�l�J�|�����%�9�Q��ڳ@)�r�QTH1~��i�ψ$�@�Oha�A0�0�f�m�r���yl	�'������VPp���I��9Fw~��n>J���@qf�S@�A���Q����EHt��R|\��� ����j��� ��Ku��L~���0��}�=��s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�l�6K]�ߧ����g��[S*+�����< ���m�^	�VN��q:�g�	R�&CʡaF�O1@B��jQ��>D�'<�h�����g�$-�w1���d��X�cu]��T��',�IiR[��d��rW3�����L��H�|Y�,�?�I�=6�*C#�è��a�)Y��ȳ���"�;&���a����|��夝i�p��Jʁ�g��̬1��qw�o	B�ZDa��� ��&��`�U�`��Rr�l��*p�M1巎�S�G-Ǿ��t}�"{Z��:������-��J*�s?M+�x��mOq-���(��B�����+���=>RY{5DUV=����0o�E����X�zC�� ��Al)�
.P����㡅c�#���ޭ����7b���.$㕖>.��gj�8��`��9Eϸ������l�?�#�\"�V�-��)K`��)}�喑p��2l���[��|�'n
A���Q��(�K���'�B�CeiateTime.Now.AddDays(30);
			}
			HttpContext.Current.Response.Cookies.Add(uinCookie);

			var sKey = new HttpCookie("skey")
			{
				Value = skey,
				Domain = currDomain
			};
			if (createPersistentCookie)
			{
				sKey.Expires = DateTime.Now.AddDays(30);
			}
			HttpContext.Current.Response.Cookies.Add(sKey);
		}

		public void SignOut()
		{
			throw new NotImplementedException();
		}
	}
}
