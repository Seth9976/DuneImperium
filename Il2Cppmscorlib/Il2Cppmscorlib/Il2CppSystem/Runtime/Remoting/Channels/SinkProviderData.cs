using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002D4 RID: 724
	public class SinkProviderData : Object
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x000EC29C File Offset: 0x000EA49C
		// Note: this type is marked as 'beforefieldinit'.
		static SinkProviderData()
		{
			Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "SinkProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr);
			SinkProviderData.NativeFieldInfoPtr_sinkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "sinkName");
			SinkProviderData.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "children");
			SinkProviderData.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "properties");
			SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100670574);
			SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100670575);
			SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100670576);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000EC344 File Offset: 0x000EA544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1381817, RefRangeEnd = 1381819, XrefRangeStart = 1381805, XrefRangeEnd = 1381817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SinkProviderData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000EC390 File Offset: 0x000EA590
		public unsafe IList Children
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000EC3D0 File Offset: 0x000EA5D0
		public unsafe IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x0000F3BF File Offset: 0x0000D5BF
		public SinkProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000EC410 File Offset: 0x000EA610
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public unsafe string sinkName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000EC438 File Offset: 0x000EA638
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0000F3E7 File Offset: 0x0000D5E7
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000EC468 File Offset: 0x000EA668
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0000F406 File Offset: 0x0000D606
		public unsafe Hashtable properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeFieldInfoPtr_sinkName;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_IList_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0;
	}
}
