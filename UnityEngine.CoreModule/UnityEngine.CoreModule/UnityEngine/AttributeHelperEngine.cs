using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000123 RID: 291
	public class AttributeHelperEngine : Object
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x0006F414 File Offset: 0x0006D614
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeHelperEngine()
		{
			Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AttributeHelperEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr);
			AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_disallowMultipleComponentArray");
			AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_executeInEditModeArray");
			AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_requireComponentArray");
			AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666505);
			AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666506);
			AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666507);
			AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666508);
			AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666509);
			AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666510);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660591, XrefRangeEnd = 660608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0006F53C File Offset: 0x0006D73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660608, XrefRangeEnd = 660668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetRequiredComponents(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0006F580 File Offset: 0x0006D780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660668, XrefRangeEnd = 660679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetExecuteMode(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0006F5C4 File Offset: 0x0006D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660679, XrefRangeEnd = 660704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CheckIsEditorScript(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0006F608 File Offset: 0x0006D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660704, XrefRangeEnd = 660710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDefaultExecutionOrderFor(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0006F64C File Offset: 0x0006D84C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 660718, RefRangeEnd = 660719, XrefRangeStart = 660710, XrefRangeEnd = 660718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0000932C File Offset: 0x0000752C
		public AttributeHelperEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0006F68C File Offset: 0x0006D88C
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00009335 File Offset: 0x00007535
		public unsafe static Il2CppReferenceArray<DisallowMultipleComponent> _disallowMultipleComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DisallowMultipleComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x0006F6B4 File Offset: 0x0006D8B4
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00009347 File Offset: 0x00007547
		public unsafe static Il2CppReferenceArray<ExecuteInEditMode> _executeInEditModeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExecuteInEditMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0006F6DC File Offset: 0x0006D8DC
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x00009359 File Offset: 0x00007559
		public unsafe static Il2CppReferenceArray<RequireComponent> _requireComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RequireComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr__disallowMultipleComponentArray;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr__executeInEditModeArray;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr__requireComponentArray;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0;

		// Token: 0x02000725 RID: 1829
		private sealed class MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>
		{
			// Token: 0x04002C31 RID: 11313
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0, Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
