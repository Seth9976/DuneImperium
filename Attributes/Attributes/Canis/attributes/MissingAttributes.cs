using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x02000018 RID: 24
	public static class MissingAttributes : Object
	{
		// Token: 0x06000176 RID: 374 RVA: 0x0000751C File Offset: 0x0000571C
		// Note: this type is marked as 'beforefieldinit'.
		static MissingAttributes()
		{
			Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "MissingAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr);
			MissingAttributes.NativeFieldInfoPtr_missingAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr, "missingAttributes");
			MissingAttributes.NativeMethodInfoPtr_get_Names_Public_Static_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr, 100663379);
			MissingAttributes.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr, 100663380);
			MissingAttributes.NativeMethodInfoPtr_GetAttribute_Public_Static_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingAttributes>.NativeClassPtr, 100663381);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000759C File Offset: 0x0000579C
		public unsafe static IEnumerable<int> Names
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215828, XrefRangeEnd = 1215839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingAttributes.NativeMethodInfoPtr_get_Names_Public_Static_get_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000075D0 File Offset: 0x000057D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215839, XrefRangeEnd = 1215847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingAttributes.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000075F8 File Offset: 0x000057F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215871, RefRangeEnd = 1215872, XrefRangeStart = 1215847, XrefRangeEnd = 1215871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAttribute GetAttribute(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingAttributes.NativeMethodInfoPtr_GetAttribute_Public_Static_IAttribute_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public MissingAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00007638 File Offset: 0x00005838
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public unsafe static ConcurrentDictionary<int, IAttribute> missingAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MissingAttributes.NativeFieldInfoPtr_missingAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<int, IAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MissingAttributes.NativeFieldInfoPtr_missingAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_missingAttributes;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Static_get_IEnumerable_1_Int32_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_IAttribute_Int32_0;
	}
}
