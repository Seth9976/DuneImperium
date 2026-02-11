using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001FC RID: 508
	[StructLayout(2)]
	public struct SubMeshDescriptor
	{
		// Token: 0x060021DA RID: 8666 RVA: 0x00094650 File Offset: 0x00092850
		// Note: this type is marked as 'beforefieldinit'.
		static SubMeshDescriptor()
		{
			Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SubMeshDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr);
			SubMeshDescriptor.NativeFieldInfoPtr__bounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<bounds>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__topology_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<topology>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__indexStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexStart>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__indexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexCount>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__baseVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<baseVertex>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__firstVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<firstVertex>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__vertexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<vertexCount>k__BackingField");
			SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667844);
			SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667845);
			SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667846);
			SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667847);
			SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667848);
			SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667849);
			SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667850);
			SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100667851);
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000947AC File Offset: 0x000929AC
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x0000CEC1 File Offset: 0x0000B0C1
		public unsafe Bounds bounds
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 681416, RefRangeEnd = 681465, XrefRangeStart = 681416, XrefRangeEnd = 681416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._bounds_k__BackingField = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000947DC File Offset: 0x000929DC
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0000CECA File Offset: 0x0000B0CA
		public unsafe MeshTopology topology
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._topology_k__BackingField = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0009480C File Offset: 0x00092A0C
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x0000CED3 File Offset: 0x0000B0D3
		public unsafe int indexStart
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._indexStart_k__BackingField = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0009483C File Offset: 0x00092A3C
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0000CEDC File Offset: 0x0000B0DC
		public unsafe int indexCount
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._indexCount_k__BackingField = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0009486C File Offset: 0x00092A6C
		// (set) Token: 0x060021E8 RID: 8680 RVA: 0x0000CEE5 File Offset: 0x0000B0E5
		public unsafe int baseVertex
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._baseVertex_k__BackingField = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0009489C File Offset: 0x00092A9C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0000CEEE File Offset: 0x0000B0EE
		public unsafe int firstVertex
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._firstVertex_k__BackingField = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000948CC File Offset: 0x00092ACC
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x0000CEF7 File Offset: 0x0000B0F7
		public unsafe int vertexCount
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._vertexCount_k__BackingField = value;
			}
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000948FC File Offset: 0x00092AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681465, XrefRangeEnd = 681502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0000CEAF File Offset: 0x0000B0AF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr__bounds_k__BackingField;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeFieldInfoPtr__topology_k__BackingField;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeFieldInfoPtr__indexStart_k__BackingField;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr__indexCount_k__BackingField;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeFieldInfoPtr__baseVertex_k__BackingField;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr__firstVertex_k__BackingField;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr__vertexCount_k__BackingField;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DC4 RID: 7620
		[FieldOffset(0)]
		public Bounds _bounds_k__BackingField;

		// Token: 0x04001DC5 RID: 7621
		[FieldOffset(24)]
		public MeshTopology _topology_k__BackingField;

		// Token: 0x04001DC6 RID: 7622
		[FieldOffset(28)]
		public int _indexStart_k__BackingField;

		// Token: 0x04001DC7 RID: 7623
		[FieldOffset(32)]
		public int _indexCount_k__BackingField;

		// Token: 0x04001DC8 RID: 7624
		[FieldOffset(36)]
		public int _baseVertex_k__BackingField;

		// Token: 0x04001DC9 RID: 7625
		[FieldOffset(40)]
		public int _firstVertex_k__BackingField;

		// Token: 0x04001DCA RID: 7626
		[FieldOffset(44)]
		public int _vertexCount_k__BackingField;
	}
}
