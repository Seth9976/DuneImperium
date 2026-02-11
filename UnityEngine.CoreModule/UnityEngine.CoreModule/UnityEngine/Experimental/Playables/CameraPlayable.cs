using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200027A RID: 634
	[StructLayout(2)]
	public struct CameraPlayable
	{
		// Token: 0x06002B3E RID: 11070 RVA: 0x000AF618 File Offset: 0x000AD818
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPlayable()
		{
			Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "CameraPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
			CameraPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, "m_Handle");
			CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100668622);
			CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100668623);
			CameraPlayable.GetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.GetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal");
			CameraPlayable.SetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.SetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal");
			CameraPlayable.InternalCreateCameraPlayableDelegateField = IL2CPP.ResolveICall<CameraPlayable.InternalCreateCameraPlayableDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable");
			CameraPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<CameraPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000AF6C0 File Offset: 0x000AD8C0
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000AF6F0 File Offset: 0x000AD8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686186, XrefRangeEnd = 686193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00010E2D File Offset: 0x0000F02D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000AF730 File Offset: 0x000AD930
		public static CameraPlayable Create(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = CameraPlayable.CreateHandle(graph, camera);
			return new CameraPlayable(playableHandle);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000AF750 File Offset: 0x000AD950
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !CameraPlayable.InternalCreateCameraPlayable(ref graph, camera, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000AF784 File Offset: 0x000AD984
		public static implicit operator UnityEngine.Playables.Playable(CameraPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
		public static explicit operator CameraPlayable(UnityEngine.Playables.Playable playable)
		{
			return new CameraPlayable(playable.GetHandle());
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000AF7C4 File Offset: 0x000AD9C4
		public Camera GetCamera()
		{
			return CameraPlayable.GetCameraInternal(ref this.m_Handle);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00010E3F File Offset: 0x0000F03F
		public void SetCamera(Camera value)
		{
			CameraPlayable.SetCameraInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000AF7E4 File Offset: 0x000AD9E4
		public static Camera GetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = CameraPlayable.GetCameraInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00010E4F File Offset: 0x0000F04F
		public static void SetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl, Camera camera)
		{
			CameraPlayable.SetCameraInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00010E62 File Offset: 0x0000F062
		public static bool InternalCreateCameraPlayable(ref UnityEngine.Playables.PlayableGraph graph, Camera camera, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return CameraPlayable.InternalCreateCameraPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(camera), ref handle);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00010E76 File Offset: 0x0000F076
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return CameraPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;

		// Token: 0x0400265D RID: 9821
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x0400265E RID: 9822
		private static readonly CameraPlayable.GetCameraInternalDelegate GetCameraInternalDelegateField;

		// Token: 0x0400265F RID: 9823
		private static readonly CameraPlayable.SetCameraInternalDelegate SetCameraInternalDelegateField;

		// Token: 0x04002660 RID: 9824
		private static readonly CameraPlayable.InternalCreateCameraPlayableDelegate InternalCreateCameraPlayableDelegateField;

		// Token: 0x04002661 RID: 9825
		private static readonly CameraPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A62 RID: 2658
		// (Invoke) Token: 0x06003DE8 RID: 15848
		private delegate IntPtr GetCameraInternalDelegate(IntPtr hdl);

		// Token: 0x02000A63 RID: 2659
		// (Invoke) Token: 0x06003DEA RID: 15850
		private delegate void SetCameraInternalDelegate(IntPtr hdl, IntPtr camera);

		// Token: 0x02000A64 RID: 2660
		// (Invoke) Token: 0x06003DEC RID: 15852
		private delegate bool InternalCreateCameraPlayableDelegate(IntPtr graph, IntPtr camera, IntPtr handle);

		// Token: 0x02000A65 RID: 2661
		// (Invoke) Token: 0x06003DEE RID: 15854
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
