using System;
using Canis.actions.responseparsers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x02000192 RID: 402
	public class StaticTargetPicker<T> : TargetPicker<T>
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x00060A64 File Offset: 0x0005EC64
		// Note: this type is marked as 'beforefieldinit'.
		static StaticTargetPicker()
		{
			Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StaticTargetPicker`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr);
			StaticTargetPicker<T>.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr, "targets");
			StaticTargetPicker<T>.NativeMethodInfoPtr__ctor_Public_Void_Match_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr, 100666986);
			StaticTargetPicker<T>.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr, 100666987);
			StaticTargetPicker<T>.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr, 100666988);
			StaticTargetPicker<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr, 100666989);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00060B34 File Offset: 0x0005ED34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 584207, RefRangeEnd = 584212, XrefRangeStart = 584203, XrefRangeEnd = 584207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticTargetPicker(Match m, IEnumerable<T> targets)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticTargetPicker<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticTargetPicker<T>.NativeMethodInfoPtr__ctor_Public_Void_Match_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00060B94 File Offset: 0x0005ED94
		public unsafe override ResponseParser<T> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584212, XrefRangeEnd = 584216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticTargetPicker<T>.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00060BE0 File Offset: 0x0005EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584216, XrefRangeEnd = 584219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticTargetPicker<T>.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00060C2C File Offset: 0x0005EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584219, XrefRangeEnd = 584227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticTargetPicker<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00008C0A File Offset: 0x00006E0A
		public StaticTargetPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00060C70 File Offset: 0x0005EE70
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x00008C13 File Offset: 0x00006E13
		public new unsafe IEnumerable<T> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticTargetPicker<T>.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticTargetPicker<T>.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_IEnumerable_1_T_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_T_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
