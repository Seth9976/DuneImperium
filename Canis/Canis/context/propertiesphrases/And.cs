using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000146 RID: 326
	[Serializable]
	public class And : PropertiesPhrase
	{
		// Token: 0x06000E84 RID: 3716 RVA: 0x00056C6C File Offset: 0x00054E6C
		// Note: this type is marked as 'beforefieldinit'.
		static And()
		{
			Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "And");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr);
			Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr, "Fst");
			Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr, "Snd");
			Canis.context.propertiesphrases.And.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr, 100666435);
			Canis.context.propertiesphrases.And.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr, 100666436);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00056CEC File Offset: 0x00054EEC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe And(PropertiesPhrase fst, PropertiesPhrase snd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canis.context.propertiesphrases.And>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canis.context.propertiesphrases.And.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00056D4C File Offset: 0x00054F4C
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Canis.context.propertiesphrases.And.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000074E9 File Offset: 0x000056E9
		public And(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00056DA4 File Offset: 0x00054FA4
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x000074F2 File Offset: 0x000056F2
		public unsafe PropertiesPhrase Fst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Fst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Fst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00056DD4 File Offset: 0x00054FD4
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00007511 File Offset: 0x00005711
		public unsafe PropertiesPhrase Snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.And.NativeFieldInfoPtr_Snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr_Fst;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr_Snd;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
