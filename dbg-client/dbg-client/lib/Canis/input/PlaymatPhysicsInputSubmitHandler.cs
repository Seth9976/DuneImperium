using System;
using boardgames.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace lib.canis.input
{
	// Token: 0x0200002B RID: 43
	public class PlaymatPhysicsInputSubmitHandler : MonoBehaviour
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00022DD8 File Offset: 0x00020FD8
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatPhysicsInputSubmitHandler()
		{
			Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "PlaymatPhysicsInputSubmitHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr);
			PlaymatPhysicsInputSubmitHandler.NativeFieldInfoPtr_playmatPhysicsInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr, "playmatPhysicsInput");
			PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr, 100663584);
			PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr, 100663585);
			PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr, 100663586);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00022E58 File Offset: 0x00021058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497732, XrefRangeEnd = 497753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00022E94 File Offset: 0x00021094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497753, XrefRangeEnd = 497755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00022EE4 File Offset: 0x000210E4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatPhysicsInputSubmitHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPhysicsInputSubmitHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPhysicsInputSubmitHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002AAD File Offset: 0x00000CAD
		public PlaymatPhysicsInputSubmitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00022F20 File Offset: 0x00021120
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002AB6 File Offset: 0x00000CB6
		public unsafe PlaymatPhysicsInput playmatPhysicsInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInputSubmitHandler.NativeFieldInfoPtr_playmatPhysicsInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaymatPhysicsInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPhysicsInputSubmitHandler.NativeFieldInfoPtr_playmatPhysicsInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_playmatPhysicsInput;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
