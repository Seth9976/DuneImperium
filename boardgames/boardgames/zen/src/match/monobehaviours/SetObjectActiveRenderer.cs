using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000075 RID: 117
	public class SetObjectActiveRenderer : MonoBehaviour
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00023E88 File Offset: 0x00022088
		// Note: this type is marked as 'beforefieldinit'.
		static SetObjectActiveRenderer()
		{
			Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "SetObjectActiveRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr);
			SetObjectActiveRenderer.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr, "key");
			SetObjectActiveRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr, 100664262);
			SetObjectActiveRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr, 100664263);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00023EF4 File Offset: 0x000220F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988432, XrefRangeEnd = 988439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00023F28 File Offset: 0x00022128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988439, XrefRangeEnd = 988443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetObjectActiveRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjectActiveRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00004C9F File Offset: 0x00002E9F
		public SetObjectActiveRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00023F64 File Offset: 0x00022164
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveRenderer.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveRenderer.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
