using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000044 RID: 68
	public sealed class ElementInit : Object
	{
		// Token: 0x060003AF RID: 943 RVA: 0x00021FC4 File Offset: 0x000201C4
		// Note: this type is marked as 'beforefieldinit'.
		static ElementInit()
		{
			Il2CppClassPointerStore<ElementInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ElementInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementInit>.NativeClassPtr);
			ElementInit.NativeFieldInfoPtr__AddMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, "<AddMethod>k__BackingField");
			ElementInit.NativeFieldInfoPtr__Arguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, "<Arguments>k__BackingField");
			ElementInit.NativeMethodInfoPtr_get_AddMethod_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, 100664177);
			ElementInit.NativeMethodInfoPtr_get_Arguments_Public_get_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, 100664178);
			ElementInit.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, 100664179);
			ElementInit.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementInit>.NativeClassPtr, 100664180);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002206C File Offset: 0x0002026C
		public unsafe MethodInfo AddMethod
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementInit.NativeMethodInfoPtr_get_AddMethod_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000220AC File Offset: 0x000202AC
		public unsafe ReadOnlyCollection<Expression> Arguments
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementInit.NativeMethodInfoPtr_get_Arguments_Public_get_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000220EC File Offset: 0x000202EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012211, XrefRangeEnd = 1012215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementInit.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00022138 File Offset: 0x00020338
		public unsafe int ArgumentCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012215, XrefRangeEnd = 1012226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementInit.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002E06 File Offset: 0x00001006
		public ElementInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00022174 File Offset: 0x00020374
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002E0F File Offset: 0x0000100F
		public unsafe MethodInfo _AddMethod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementInit.NativeFieldInfoPtr__AddMethod_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementInit.NativeFieldInfoPtr__AddMethod_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000221A4 File Offset: 0x000203A4
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002E2E File Offset: 0x0000102E
		public unsafe ReadOnlyCollection<Expression> _Arguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementInit.NativeFieldInfoPtr__Arguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementInit.NativeFieldInfoPtr__Arguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr__AddMethod_k__BackingField;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr__Arguments_k__BackingField;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_AddMethod_Public_get_MethodInfo_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_ReadOnlyCollection_1_Expression_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0;
	}
}
