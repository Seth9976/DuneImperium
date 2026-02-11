using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000065 RID: 101
	public class ReflectionMember : Object
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x0003B254 File Offset: 0x00039454
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionMember()
		{
			Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ReflectionMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr);
			ReflectionMember.NativeFieldInfoPtr__MemberType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, "<MemberType>k__BackingField");
			ReflectionMember.NativeFieldInfoPtr__Getter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, "<Getter>k__BackingField");
			ReflectionMember.NativeFieldInfoPtr__Setter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, "<Setter>k__BackingField");
			ReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664986);
			ReflectionMember.NativeMethodInfoPtr_set_MemberType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664987);
			ReflectionMember.NativeMethodInfoPtr_get_Getter_Public_get_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664988);
			ReflectionMember.NativeMethodInfoPtr_set_Getter_Public_set_Void_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664989);
			ReflectionMember.NativeMethodInfoPtr_get_Setter_Public_get_Action_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664990);
			ReflectionMember.NativeMethodInfoPtr_set_Setter_Public_set_Void_Action_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664991);
			ReflectionMember.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr, 100664992);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0003B34C File Offset: 0x0003954C
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0003B38C File Offset: 0x0003958C
		public unsafe Type MemberType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_set_MemberType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0003B3D0 File Offset: 0x000395D0
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0003B410 File Offset: 0x00039610
		public unsafe Func<Object, Object> Getter
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_get_Getter_Public_get_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_set_Getter_Public_set_Void_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0003B454 File Offset: 0x00039654
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0003B494 File Offset: 0x00039694
		public unsafe Action<Object, Object> Setter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_get_Setter_Public_get_Action_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr_set_Setter_Public_set_Void_Action_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003B4D8 File Offset: 0x000396D8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionMember()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMember>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMember.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00004C32 File Offset: 0x00002E32
		public ReflectionMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0003B514 File Offset: 0x00039714
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00004C3B File Offset: 0x00002E3B
		public unsafe Type _MemberType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__MemberType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__MemberType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0003B544 File Offset: 0x00039744
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00004C5A File Offset: 0x00002E5A
		public unsafe Func<Object, Object> _Getter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__Getter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__Getter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0003B574 File Offset: 0x00039774
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00004C79 File Offset: 0x00002E79
		public unsafe Action<Object, Object> _Setter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__Setter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMember.NativeFieldInfoPtr__Setter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr__MemberType_k__BackingField;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr__Getter_k__BackingField;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr__Setter_k__BackingField;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_get_Type_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberType_Public_set_Void_Type_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_Getter_Public_get_Func_2_Object_Object_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_set_Getter_Public_set_Void_Func_2_Object_Object_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_get_Setter_Public_get_Action_2_Object_Object_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_set_Setter_Public_set_Void_Action_2_Object_Object_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
