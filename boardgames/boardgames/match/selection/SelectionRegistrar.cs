using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.match.selection
{
	// Token: 0x0200012C RID: 300
	public class SelectionRegistrar : MonoBehaviour
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x00040D90 File Offset: 0x0003EF90
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionRegistrar()
		{
			Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.selection", "SelectionRegistrar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr);
			SelectionRegistrar.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr, 100665533);
			SelectionRegistrar.NativeMethodInfoPtr_getSelectionNodeFactory_Protected_Virtual_New_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr, 100665534);
			SelectionRegistrar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr, 100665535);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00040DFC File Offset: 0x0003EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998102, XrefRangeEnd = 998107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRegistrar.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00040E30 File Offset: 0x0003F030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998107, XrefRangeEnd = 998126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNodeFactory getSelectionNodeFactory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionRegistrar.NativeMethodInfoPtr_getSelectionNodeFactory_Protected_Virtual_New_ISelectionNodeFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNodeFactory>(intPtr3) : null;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00040E7C File Offset: 0x0003F07C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionRegistrar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRegistrar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRegistrar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000094CF File Offset: 0x000076CF
		public SelectionRegistrar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_getSelectionNodeFactory_Protected_Virtual_New_ISelectionNodeFactory_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
