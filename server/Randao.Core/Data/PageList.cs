�}�
  \   @��h쓩_�u
��2�c��v�б��ް4HԨy�"x��Es�{�� �P!h{�L�:�O�����I V�/�ȑږ�t�xz
�Fx~�� ���s��#_�/��g��;���#U��S�Cf�� tgd�9�@z�
bx�Q����u�}C7�+�~bM���K��&^�"+S�{i�Ge\O�i��e�3�~��H�MC��V{ty؋_=�c檑9pZ��Hf,jP%����>`ߟ�2ٔ�Ϯ�5��A��<�'Q�49�wi`e-Y5D!�П�pb}N���]���G{�H��#��M^���iKY0{@PF���o0�u���g�I��zH���r-�����4�s욈�

�y�53h��w�v=Z��р���<�,�3S��U4O��ał-t*�.����pD&��X���Q+�� �pw��ʨ��x`�k��7y�a�9[��O���R`��������j�@*jQ�am�z�$�f��z
9�get; set; }

		/// <summary>
		/// 每页数量
		/// </summary>
		[DataMember(Name = "page_size")]
		public int PageSize { get; set; }

		/// <summary>
		/// 分页数据
		/// </summary>
		[DataMember(Name = "data_list")]
		public List<T> DataList { get; set; }

		[DataMember(Name = "page_count")]
		public int PageCount
		{
			get
			{
				return (int)Math.Ceiling(TotalCount * 1.0 / this.PageSize);
			}
		}
	}
}
