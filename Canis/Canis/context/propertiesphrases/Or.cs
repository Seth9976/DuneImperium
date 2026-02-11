using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public class Or : PropertiesPhrase
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x00056E04 File Offset: 0x00055004
		// Note: this type is marked as 'beforefieldinit'.
		static Or()
		{
			Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "Or");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr);
			Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr, "Fst");
			Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr, "Snd");
			Canis.context.propertiesphrases.Or.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr, 100666437);
			Canis.context.propertiesphrases.Or.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr, 100666438);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00056E84 File Offset: 0x00055084
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Or(PropertiesPhrase fst, PropertiesPhrase snd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canis.context.propertiesphrases.Or>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canis.context.propertiesphrases.Or.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00056EE4 File Offset: 0x000550E4
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Canis.context.propertiesphrases.Or.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00007530 File Offset: 0x00005730
		public Or(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00056F3C File Offset: 0x0005513C
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00007539 File Offset: 0x00005739
		public unsafe PropertiesPhrase Fst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Fst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Fst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00056F6C File Offset: 0x0005516C
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00007558 File Offset: 0x00005758
		public unsafe PropertiesPhrase Snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Canis.context.propertiesphrases.Or.NativeFieldInfoPtr_Snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_Fst;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_Snd;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_PropertiesPhrase_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
