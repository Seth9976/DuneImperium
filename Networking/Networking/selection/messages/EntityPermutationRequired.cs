using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.messages
{
	// Token: 0x0200007F RID: 127
	public class EntityPermutationRequired : SelectionMessage
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x000112A4 File Offset: 0x0000F4A4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityPermutationRequired()
		{
			Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "EntityPermutationRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr);
			EntityPermutationRequired.NativeFieldInfoPtr_permutations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, "permutations");
			EntityPermutationRequired.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, "forced");
			EntityPermutationRequired.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, "Kind");
			EntityPermutationRequired.NativeFieldInfoPtr_SelectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, "SelectionParams");
			EntityPermutationRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, 100663569);
			EntityPermutationRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, 100663570);
			EntityPermutationRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr, 100663571);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00011360 File Offset: 0x0000F560
		public unsafe virtual Dictionary<string, Object> Params
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityPermutationRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194530, XrefRangeEnd = 1194532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityPermutationRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000113E4 File Offset: 0x0000F5E4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityPermutationRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityPermutationRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityPermutationRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004986 File Offset: 0x00002B86
		public EntityPermutationRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00011420 File Offset: 0x0000F620
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000498F File Offset: 0x00002B8F
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<EntityID>> permutations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_permutations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_permutations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00011450 File Offset: 0x0000F650
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000049AE File Offset: 0x00002BAE
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00011478 File Offset: 0x0000F678
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x000049C9 File Offset: 0x00002BC9
		public unsafe string Kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_Kind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_Kind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000114A0 File Offset: 0x0000F6A0
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000049E8 File Offset: 0x00002BE8
		public unsafe Dictionary<string, Object> SelectionParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_SelectionParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityPermutationRequired.NativeFieldInfoPtr_SelectionParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_permutations;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_Kind;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_SelectionParams;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
