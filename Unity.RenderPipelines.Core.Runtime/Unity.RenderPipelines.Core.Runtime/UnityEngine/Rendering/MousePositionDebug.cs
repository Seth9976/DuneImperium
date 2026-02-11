using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000076 RID: 118
	public class MousePositionDebug : Object
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x0002AF9C File Offset: 0x0002919C
		// Note: this type is marked as 'beforefieldinit'.
		static MousePositionDebug()
		{
			Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MousePositionDebug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr);
			MousePositionDebug.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, "s_Instance");
			MousePositionDebug.NativeMethodInfoPtr_get_instance_Public_Static_get_MousePositionDebug_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664547);
			MousePositionDebug.NativeMethodInfoPtr_Build_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664548);
			MousePositionDebug.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664549);
			MousePositionDebug.NativeMethodInfoPtr_GetMousePosition_Public_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664550);
			MousePositionDebug.NativeMethodInfoPtr_GetInputMousePosition_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664551);
			MousePositionDebug.NativeMethodInfoPtr_GetMouseClickPosition_Public_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664552);
			MousePositionDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr, 100664553);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0002B06C File Offset: 0x0002926C
		public unsafe static MousePositionDebug instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964920, XrefRangeEnd = 964928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_get_instance_Public_Static_get_MousePositionDebug_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MousePositionDebug>(intPtr3) : null;
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0002B0A0 File Offset: 0x000292A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_Build_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0002B0D4 File Offset: 0x000292D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002B108 File Offset: 0x00029308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964928, XrefRangeEnd = 964929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMousePosition(float ScreenHeight, bool sceneView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ScreenHeight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_GetMousePosition_Public_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002B160 File Offset: 0x00029360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetInputMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_GetInputMousePosition_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002B19C File Offset: 0x0002939C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 964931, RefRangeEnd = 964956, XrefRangeStart = 964929, XrefRangeEnd = 964931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMouseClickPosition(float ScreenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ScreenHeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr_GetMouseClickPosition_Public_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0002B1E8 File Offset: 0x000293E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MousePositionDebug()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePositionDebug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePositionDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0000519D File Offset: 0x0000339D
		public MousePositionDebug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002B224 File Offset: 0x00029424
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x000051A6 File Offset: 0x000033A6
		public unsafe static MousePositionDebug s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MousePositionDebug.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePositionDebug>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MousePositionDebug.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_MousePositionDebug_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Void_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePosition_Public_Vector2_Single_Boolean_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_GetInputMousePosition_Private_Vector2_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseClickPosition_Public_Vector2_Single_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
