using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public sealed class AbilityID : TypedID
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00008210 File Offset: 0x00006410
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityID()
		{
			Il2CppClassPointerStore<AbilityID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "AbilityID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityID>.NativeClassPtr);
			AbilityID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityID>.NativeClassPtr, "Empty");
			AbilityID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityID>.NativeClassPtr, 100663443);
			AbilityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityID>.NativeClassPtr, 100663444);
			AbilityID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityID>.NativeClassPtr, 100663445);
			AbilityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityID>.NativeClassPtr, 100663446);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000082A4 File Offset: 0x000064A4
		[CallerCount(959)]
		[CachedScanResults(RefRangeStart = 1178674, RefRangeEnd = 1179633, XrefRangeStart = 1178669, XrefRangeEnd = 1178674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000082F0 File Offset: 0x000064F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179637, RefRangeEnd = 1179638, XrefRangeStart = 1179633, XrefRangeEnd = 1179637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008338 File Offset: 0x00006538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179638, XrefRangeEnd = 1179643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008374 File Offset: 0x00006574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179643, XrefRangeEnd = 1179651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000024A2 File Offset: 0x000006A2
		public AbilityID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000083B8 File Offset: 0x000065B8
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000024AB File Offset: 0x000006AB
		public unsafe static AbilityID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbilityID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
