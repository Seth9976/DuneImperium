using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A6 RID: 166
	public class DragAndDropData : Object
	{
		// Token: 0x06001039 RID: 4153 RVA: 0x000560B8 File Offset: 0x000542B8
		// Note: this type is marked as 'beforefieldinit'.
		static DragAndDropData()
		{
			Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DragAndDropData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr);
			DragAndDropData.NativeMethodInfoPtr_GetGenericData_Public_Abstract_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr, 100665634);
			DragAndDropData.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr, 100665635);
			DragAndDropData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr, 100665636);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00056124 File Offset: 0x00054324
		[CallerCount(0)]
		public unsafe virtual Object GetGenericData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragAndDropData.NativeMethodInfoPtr_GetGenericData_Public_Abstract_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00056180 File Offset: 0x00054380
		public unsafe virtual Object source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragAndDropData.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000561CC File Offset: 0x000543CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragAndDropData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragAndDropData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000082A4 File Offset: 0x000064A4
		public DragAndDropData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000082AD File Offset: 0x000064AD
		public Object UnityEngine.UIElements.IDragAndDropData.userData
		{
			get
			{
				return this.GetGenericData("__unity-drag-and-drop__source-view");
			}
		}

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericData_Public_Abstract_Virtual_New_Object_String_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B38 RID: 2872
		public const string dragSourceKey = "__unity-drag-and-drop__source-view";
	}
}
