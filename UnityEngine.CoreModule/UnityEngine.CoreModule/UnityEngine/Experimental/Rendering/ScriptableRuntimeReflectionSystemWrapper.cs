using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000281 RID: 641
	public class ScriptableRuntimeReflectionSystemWrapper : Object
	{
		// Token: 0x06002B87 RID: 11143 RVA: 0x000B00D4 File Offset: 0x000AE2D4
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemWrapper()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, "<implementation>k__BackingField");
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100668639);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100668640);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100668641);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100668642);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000B0168 File Offset: 0x000AE368
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x000B01A8 File Offset: 0x000AE3A8
		public unsafe IScriptableRuntimeReflectionSystem implementation
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000B01EC File Offset: 0x000AE3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686244, XrefRangeEnd = 686245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000B022C File Offset: 0x000AE42C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRuntimeReflectionSystemWrapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00010FC3 File Offset: 0x0000F1C3
		public ScriptableRuntimeReflectionSystemWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000B0268 File Offset: 0x000AE468
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public unsafe IScriptableRuntimeReflectionSystem _implementation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeFieldInfoPtr__implementation_k__BackingField;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
