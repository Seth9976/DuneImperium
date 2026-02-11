using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class IntentFitness : Object
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x0004D354 File Offset: 0x0004B554
		// Note: this type is marked as 'beforefieldinit'.
		static IntentFitness()
		{
			Il2CppClassPointerStore<IntentFitness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "IntentFitness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntentFitness>.NativeClassPtr);
			IntentFitness.NativeFieldInfoPtr_intent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFitness>.NativeClassPtr, "intent");
			IntentFitness.NativeFieldInfoPtr_fitness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntentFitness>.NativeClassPtr, "fitness");
			IntentFitness.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntentFitness>.NativeClassPtr, 100665908);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0004D3C0 File Offset: 0x0004B5C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntentFitness(string i, int f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntentFitness>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntentFitness.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00006439 File Offset: 0x00004639
		public IntentFitness(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0004D41C File Offset: 0x0004B61C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00006442 File Offset: 0x00004642
		public unsafe string intent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentFitness.NativeFieldInfoPtr_intent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentFitness.NativeFieldInfoPtr_intent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0004D444 File Offset: 0x0004B644
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00006461 File Offset: 0x00004661
		public unsafe int fitness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentFitness.NativeFieldInfoPtr_fitness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntentFitness.NativeFieldInfoPtr_fitness)) = value;
			}
		}

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_intent;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_fitness;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
