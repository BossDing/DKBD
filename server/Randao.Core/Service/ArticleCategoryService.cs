�}�
  m   ؤ榒��_�u
��� �cD�v�F�b�[4��=��a�8��s-P�/lF��F�G�
b�FמÚ5��e/����\��c�āa�|��sP%,���n�D���x�߬�^o���2�j�e�W���|���12�$�M���'�1���&�o��)��ɥx�@�0�z3	Z��Z�n�Kػ6�Q��:��t��N?��%��<����<ָ`�l�ږ���Ǌ�V��G���@<�`T/��:��y�����o��#���ugzV�!�Dʧ��܋���N@{�(���z��_t�b�S�d��"�]�b)�0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�l�"+|�kh�B�Ww��`_�Η�:R�����V�_p�3{�zM)�G��0�Բ�M�Rl���'�U�9�`��[K8e3�&l�W8���:>�mk�#�&������@��NM�a;2B�H^�.����%1Z�`'p:���*f�~0����Uâ�QЬ̪^g����Ƶ��D²$�ٺa�&�]�0�.l1��zM�	�&�s
=�Ɋ��C#U�B���B���?Gŭ߬��+��D�f�o�{��6"�Z��.#[L�9��έǷ��;���������£f��Z�%��.�p��3��b��q���*��J�Slg�AH�����a�^m6a��$"�'H">��Eq�]��c��)7�N%���D!���th!��(�~'j�߽�H�9�y�=@��ʗ�N��J?��cR�Fe��Lk�N�Iߤ���[��G
���;����]�0��u���,�#�Gc�黼���ir�,��O���6(�@��t����^��5�
				return categoryId;
			}
			return Convert.ToInt32(categoryList.First());
		}

		internal List<int> GetParentCategoryList(int categoryId)
		{
			var articleCategory = ArticleCategoryRepository.Instance.GetArticleCategory(categoryId);
			if (null == articleCategory)
			{
				return new List<int>();
			}
			return articleCategory.parentIdList.Split(new char[] { '|' }, System.StringSplitOptions.RemoveEmptyEntries).Select(t => Convert.ToInt32(t)).ToList();
		}
	}
}
