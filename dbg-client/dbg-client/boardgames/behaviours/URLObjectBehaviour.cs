using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002B6 RID: 694
	public class URLObjectBehaviour : MonoBehaviour
	{
		// Token: 0x060020C3 RID: 8387 RVA: 0x0008A98C File Offset: 0x00088B8C
		// Note: this type is marked as 'beforefieldinit'.
		static URLObjectBehaviour()
		{
			Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "URLObjectBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr);
			URLObjectBehaviour.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr, "url");
			URLObjectBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr, 100668739);
			URLObjectBehaviour.NativeMethodInfoPtr_Event_OpenURL_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr, 100668740);
			URLObjectBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr, 100668741);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0008AA0C File Offset: 0x00088C0C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLObjectBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0008AA40 File Offset: 0x00088C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542779, XrefRangeEnd = 542790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OpenURL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLObjectBehaviour.NativeMethodInfoPtr_Event_OpenURL_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0008AA74 File Offset: 0x00088C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542790, XrefRangeEnd = 542800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe URLObjectBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URLObjectBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLObjectBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00011271 File Offset: 0x0000F471
		public URLObjectBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0008AAB0 File Offset: 0x00088CB0
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0001127A File Offset: 0x0000F47A
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLObjectBehaviour.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLObjectBehaviour.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_Event_OpenURL_Public_Void_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
