using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace lotus
{
	// Token: 0x02000008 RID: 8
	public class CutsceneContext : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003964 File Offset: 0x00001B64
		// Note: this type is marked as 'beforefieldinit'.
		static CutsceneContext()
		{
			Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutsceneContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr);
			CutsceneContext.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, "Sequence");
			CutsceneContext.NativeFieldInfoPtr__ShouldContinue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, "<ShouldContinue>k__BackingField");
			CutsceneContext.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, "parameters");
			CutsceneContext.NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663340);
			CutsceneContext.NativeMethodInfoPtr_get_ShouldContinue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663341);
			CutsceneContext.NativeMethodInfoPtr_set_ShouldContinue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663342);
			CutsceneContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663343);
			CutsceneContext.NativeMethodInfoPtr__ctor_Public_Void_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663344);
			CutsceneContext.NativeMethodInfoPtr_Get_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr, 100663345);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003A48 File Offset: 0x00001C48
		public unsafe Dictionary<string, Object> Parameters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003A88 File Offset: 0x00001C88
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public unsafe bool ShouldContinue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.NativeMethodInfoPtr_get_ShouldContinue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.NativeMethodInfoPtr_set_ShouldContinue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003B04 File Offset: 0x00001D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258139, XrefRangeEnd = 1258147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003B40 File Offset: 0x00001D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258147, XrefRangeEnd = 1258158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneContext(string key, Object val, bool shouldContinue = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldContinue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.NativeMethodInfoPtr__ctor_Public_Void_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003BAC File Offset: 0x00001DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258158, XrefRangeEnd = 1258165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get<T>(string key) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneContext.MethodInfoStoreGeneric_Get_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021A8 File Offset: 0x000003A8
		public CutsceneContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000021B1 File Offset: 0x000003B1
		public unsafe static string Sequence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CutsceneContext.NativeFieldInfoPtr_Sequence, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CutsceneContext.NativeFieldInfoPtr_Sequence, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000021C3 File Offset: 0x000003C3
		public unsafe bool _ShouldContinue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneContext.NativeFieldInfoPtr__ShouldContinue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneContext.NativeFieldInfoPtr__ShouldContinue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003C40 File Offset: 0x00001E40
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000021DE File Offset: 0x000003DE
		public unsafe Dictionary<string, Object> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneContext.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneContext.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_Sequence;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__ShouldContinue_k__BackingField;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldContinue_Public_get_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldContinue_Public_set_Void_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_String_0;

		// Token: 0x02000023 RID: 35
		private sealed class MethodInfoStoreGeneric_Get_Public_T_String_0<T>
		{
			// Token: 0x040000BB RID: 187
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CutsceneContext.NativeMethodInfoPtr_Get_Public_T_String_0, Il2CppClassPointerStore<CutsceneContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
