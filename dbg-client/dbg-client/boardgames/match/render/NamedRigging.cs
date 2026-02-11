using System;
using boardgames.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.match.render
{
	// Token: 0x0200029A RID: 666
	public class NamedRigging : MonoBehaviour
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x00085CA8 File Offset: 0x00083EA8
		// Note: this type is marked as 'beforefieldinit'.
		static NamedRigging()
		{
			Il2CppClassPointerStore<NamedRigging>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.render", "NamedRigging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr);
			NamedRigging.NativeFieldInfoPtr_rigName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "rigName");
			NamedRigging.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "lights");
			NamedRigging.NativeFieldInfoPtr_cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "cameras");
			NamedRigging.NativeFieldInfoPtr_includeMainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "includeMainCamera");
			NamedRigging.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "canvases");
			NamedRigging.NativeFieldInfoPtr_fogAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "fogAnimators");
			NamedRigging.NativeFieldInfoPtr_isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "isDefault");
			NamedRigging.NativeFieldInfoPtr__RigClearCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, "<RigClearCamera>k__BackingField");
			NamedRigging.NativeMethodInfoPtr_get_RigClearCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668532);
			NamedRigging.NativeMethodInfoPtr_set_RigClearCamera_Private_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668533);
			NamedRigging.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668534);
			NamedRigging.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668535);
			NamedRigging.NativeMethodInfoPtr_Activate_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668536);
			NamedRigging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr, 100668537);
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00085DF0 File Offset: 0x00083FF0
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00085E30 File Offset: 0x00084030
		public unsafe Camera RigClearCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr_get_RigClearCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr_set_RigClearCamera_Private_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00085E74 File Offset: 0x00084074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541030, XrefRangeEnd = 541064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00085EA8 File Offset: 0x000840A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541064, XrefRangeEnd = 541070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00085EDC File Offset: 0x000840DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541141, RefRangeEnd = 541143, XrefRangeStart = 541070, XrefRangeEnd = 541141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(bool active, bool skipMain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipMain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr_Activate_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00085F28 File Offset: 0x00084128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541143, XrefRangeEnd = 541175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedRigging()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedRigging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedRigging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00010692 File Offset: 0x0000E892
		public NamedRigging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00085F64 File Offset: 0x00084164
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0001069B File Offset: 0x0000E89B
		public unsafe string rigName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_rigName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_rigName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00085F8C File Offset: 0x0008418C
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x000106BA File Offset: 0x0000E8BA
		public unsafe List<Light> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00085FBC File Offset: 0x000841BC
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x000106D9 File Offset: 0x0000E8D9
		public unsafe List<Camera> cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00085FEC File Offset: 0x000841EC
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x000106F8 File Offset: 0x0000E8F8
		public unsafe bool includeMainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_includeMainCamera);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_includeMainCamera)) = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00086014 File Offset: 0x00084214
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00010713 File Offset: 0x0000E913
		public unsafe List<Canvas> canvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_canvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_canvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00086044 File Offset: 0x00084244
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00010732 File Offset: 0x0000E932
		public unsafe List<AnimateFogSettings> fogAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_fogAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimateFogSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_fogAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00086074 File Offset: 0x00084274
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00010751 File Offset: 0x0000E951
		public unsafe bool isDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_isDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr_isDefault)) = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0008609C File Offset: 0x0008429C
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0001076C File Offset: 0x0000E96C
		public unsafe Camera _RigClearCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr__RigClearCamera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedRigging.NativeFieldInfoPtr__RigClearCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_rigName;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_cameras;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_includeMainCamera;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_canvases;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_fogAnimators;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_isDefault;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr__RigClearCamera_k__BackingField;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_get_RigClearCamera_Public_get_Camera_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_set_RigClearCamera_Private_set_Void_Camera_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Boolean_Boolean_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
