�}
  h   ���j���_�u
��	�cL
Ɔ��0�UB8�A���]*b����xb(8|)bpu��Dwt�L��4�w�BK�b�.�Ti�4#�;�͡@ъrdk�/�x�H�Q�{�lQEBX����O�Y��2+H�)�D)LzzmZ��F<mΐR� �[��q��K�WQ"1Smp���K\�����_������-�-��6﹂~���1�)7P1��d�X�նsҺ��k�X�i q�zV�{����'m��
�k9���^�՗춃nղ?ʭ{}�5޽N@{�(���z��_t�b�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�l�.��B}t8�Ǫ7�6O�b�RHH1����c���^d�j�����ǶΏ�h��o=9���4�c�P���V��	$�C���pKhe�)��b�h���{�^fN�#�Z��	"9�#�̹���J�����s-�qgθ��)�cb��W�<�����܎����õ��J�jo�\B��,$n�F�L��;���Bz7�8�*���T�7�'1+�n�u�2����7�	@�')(�<��e�y= ����<���͢9��,��Ѻ��s�|gi�^ٟ�r-���e���xHٴ/.����<��$���a��xk7P!/�]T���L�x����Ӿ�*E�A3��DM���ms��脀��cOD��&���Yx�fY�Y����[ ������q���������%Ǌ��+�Nz�u�B��>�^�Xm8�;7�n}A�1/%���Y�S����EU��p��sLs�C�m��צ�H-�6k4k0h.��c���0MO�l�$���8�Zm/�rpmp)��{�q�I@��!�\e�f^��d�T�������0�oA���>\� �s{���U�D]4,5�]wH�[J�v�>��mi8n�o�}J.��H3E��V��ظ���͇*�J��!�Pwm~�;sy�5�o�~1JzUM�5�dի�hs�VN�_9��<Z4+�w�&�e�t�.U�}۔����}+�0�v:h�k%4���bH+�-�X�f|�߆$-�o5�o%_OYr�ݾ�8E�&��d-ĸ��T���҆��.�K��
(\��~P&�L#�ޓ]��X#�z�G ݶ[Aj�p�3�[O�г���ꮷObe,���xL��~�+&P������+GB9�7��pc~�W��/@��}���$�fמ(:�~V��*���8�AiTڿ0֨P�#��m�Q��'������u㙼�,_�?[K^,u<�/wފ ���ml�N]�r�ئa
O4=ɽ�8����Z������k������� k�l�-	>;�'X�60�vR���ay8��mQc��yz������ei5�oBˎ.K)���&�߷7x��1��םJ�����5��c�i���J��.QڌV��#g_�%VV��C�'����$r����q�ɗ�'ސrℙ��Ή�c7� ��#6����m)=֬����0ѶinrK#�b�����'e�.�2��v��A��ZF�M�3w��9�]n���uƶ��M`ϱf���pxl�2��*�c�C?�Px5�;�s;��ꙥVMȰC�VoK��.������;p8�|ÿ�ǁ{`� �O��V�|�iՊ[����w0��<Ʉ���C�}���!���^��n�N���8�
P�Ys���Bتs�J7�O�gR�61n2X���Q��o;���gg7�5���zn�V�藵}O�?:�b8r�6�(�F�A�¾Z�AW�!�3F���M.�����Za�Ue�]_Y.,T��c���k��I�S���Mr:C�:�f��l�,na]h�̎��)���Y0��a����];9��9�kG�S/A��P^qѣja�F����4r�����R,�y���"����Z��L�KI����F�'�lhA�w&��e���hĶk��ƷV�������'!$�$�����Kl��s4�V'aQsŴdB9�.�evN�����. T�f��:�<C	WL��j�G�<I�=��Ql_HrL*O?�Ǥ��J,!8���9x�ۦ9�~�
�#J/ �)4)Q�g@Jn A_�M��k���Z�X���	�J7뚕ҋ�Na���aό@��C��I(f�+IGϺ����.Ciٖ��MgO��.�(_���2g �%�����1������	g���繶�@�׊�?VDF�<Q+����d�%K�[�;r#C�NI-��.T ����>�R[�i����Hͥ���ّS�h��E�	67�"�9��.�ʹ�F��f5�5�K�?��+�,c��ߊi[i��)��ࠤ��� ��Jb<y�/p�}�rs�&�r'/��werCount),
				new SqlParameter("@EggCount", model.EggCount),
				new SqlParameter("@WarnCount", model.WarnCount),
				new SqlParameter("@TableName", model.TableName),
				new SqlParameter("@UserKeyId", model.UserKeyId)
			};

			model.CommentID = Convert.ToInt64(SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, sql, _parm));

			return model.CommentID > 0;
		}

		public bool DeleteArticleComment(long id)
		{
			return false;
		}
    }
}
