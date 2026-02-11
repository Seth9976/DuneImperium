using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000111 RID: 273
	public class DisableMoz : MonoBehaviour
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00044AFC File Offset: 0x00042CFC
		// Note: this type is marked as 'beforefieldinit'.
		static DisableMoz()
		{
			Il2CppClassPointerStore<DisableMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "DisableMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr);
			DisableMoz.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr, "mozManager");
			DisableMoz.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr, 100665110);
			DisableMoz.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr, 100665111);
			DisableMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr, 100665112);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00044B7C File Offset: 0x00042D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509776, XrefRangeEnd = 509784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableMoz.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00044BB0 File Offset: 0x00042DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509784, XrefRangeEnd = 509789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableMoz.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00044BE4 File Offset: 0x00042DE4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisableMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00007FF1 File Offset: 0x000061F1
		public DisableMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00044C20 File Offset: 0x00042E20
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00007FFA File Offset: 0x000061FA
		public unsafe MozManager mozManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableMoz.NativeFieldInfoPtr_mozManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableMoz.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_mozManager;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
