using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x02000010 RID: 16
	public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000055E0 File Offset: 0x000037E0
		// Note: this type is marked as 'beforefieldinit'.
		static XRInputSubsystem()
		{
			Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr);
			XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "trackingOriginUpdated");
			XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "boundaryChanged");
			XRInputSubsystem.NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663356);
			XRInputSubsystem.NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663357);
			XRInputSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663358);
			XRInputSubsystem.GetIndexDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetIndexDelegate>("UnityEngine.XR.XRInputSubsystem::GetIndex");
			XRInputSubsystem.TryRecenterDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryRecenterDelegate>("UnityEngine.XR.XRInputSubsystem::TryRecenter");
			XRInputSubsystem.TrySetTrackingOriginModeDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TrySetTrackingOriginModeDelegate>("UnityEngine.XR.XRInputSubsystem::TrySetTrackingOriginMode");
			XRInputSubsystem.GetTrackingOriginModeDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetTrackingOriginModeDelegate>("UnityEngine.XR.XRInputSubsystem::GetTrackingOriginMode");
			XRInputSubsystem.GetSupportedTrackingOriginModesDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetSupportedTrackingOriginModesDelegate>("UnityEngine.XR.XRInputSubsystem::GetSupportedTrackingOriginModes");
			XRInputSubsystem.TryGetBoundaryPoints_AsListDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryGetBoundaryPoints_AsListDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetBoundaryPoints_AsList");
			XRInputSubsystem.TryGetDeviceIds_AsListDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryGetDeviceIds_AsListDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetDeviceIds_AsList");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000056E0 File Offset: 0x000038E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258831, XrefRangeEnd = 1258838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005714 File Offset: 0x00003914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258838, XrefRangeEnd = 1258845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeBoundaryChangedEvent(IntPtr internalPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005748 File Offset: 0x00003948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258845, XrefRangeEnd = 1258848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRInputSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002911 File Offset: 0x00000B11
		public XRInputSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005784 File Offset: 0x00003984
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000291A File Offset: 0x00000B1A
		public unsafe Action<XRInputSubsystem> trackingOriginUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRInputSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000057B4 File Offset: 0x000039B4
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002939 File Offset: 0x00000B39
		public unsafe Action<XRInputSubsystem> boundaryChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRInputSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002958 File Offset: 0x00000B58
		public uint GetIndex()
		{
			return XRInputSubsystem.GetIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000296A File Offset: 0x00000B6A
		public bool TryRecenter()
		{
			return XRInputSubsystem.TryRecenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000297C File Offset: 0x00000B7C
		public bool TryGetInputDevices(List<InputDevice> devices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002989 File Offset: 0x00000B89
		public bool TrySetTrackingOriginMode(TrackingOriginModeFlags origin)
		{
			return XRInputSubsystem.TrySetTrackingOriginModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), origin);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000299C File Offset: 0x00000B9C
		public TrackingOriginModeFlags GetTrackingOriginMode()
		{
			return XRInputSubsystem.GetTrackingOriginModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000029AE File Offset: 0x00000BAE
		public TrackingOriginModeFlags GetSupportedTrackingOriginModes()
		{
			return XRInputSubsystem.GetSupportedTrackingOriginModesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000057E4 File Offset: 0x000039E4
		public bool TryGetBoundaryPoints(List<Vector3> boundaryPoints)
		{
			bool flag = boundaryPoints == null;
			if (flag)
			{
				throw new ArgumentNullException("boundaryPoints");
			}
			return this.TryGetBoundaryPoints_AsList(boundaryPoints);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000029C0 File Offset: 0x00000BC0
		public bool TryGetBoundaryPoints_AsList(List<Vector3> boundaryPoints)
		{
			return XRInputSubsystem.TryGetBoundaryPoints_AsListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(boundaryPoints));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000029D8 File Offset: 0x00000BD8
		public void add_trackingOriginUpdated(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000029E5 File Offset: 0x00000BE5
		public void remove_trackingOriginUpdated(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000029F2 File Offset: 0x00000BF2
		public void add_boundaryChanged(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000029FF File Offset: 0x00000BFF
		public void remove_boundaryChanged(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002A0C File Offset: 0x00000C0C
		public void TryGetDeviceIds_AsList(List<ulong> deviceIds)
		{
			XRInputSubsystem.TryGetDeviceIds_AsListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(deviceIds));
		}

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_trackingOriginUpdated;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_boundaryChanged;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly XRInputSubsystem.GetIndexDelegate GetIndexDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly XRInputSubsystem.TryRecenterDelegate TryRecenterDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly XRInputSubsystem.TrySetTrackingOriginModeDelegate TrySetTrackingOriginModeDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly XRInputSubsystem.GetTrackingOriginModeDelegate GetTrackingOriginModeDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly XRInputSubsystem.GetSupportedTrackingOriginModesDelegate GetSupportedTrackingOriginModesDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly XRInputSubsystem.TryGetBoundaryPoints_AsListDelegate TryGetBoundaryPoints_AsListDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly XRInputSubsystem.TryGetDeviceIds_AsListDelegate TryGetDeviceIds_AsListDelegateField;

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate uint GetIndexDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate bool TryRecenterDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate bool TrySetTrackingOriginModeDelegate(IntPtr @this, TrackingOriginModeFlags origin);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate TrackingOriginModeFlags GetTrackingOriginModeDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate TrackingOriginModeFlags GetSupportedTrackingOriginModesDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate bool TryGetBoundaryPoints_AsListDelegate(IntPtr @this, IntPtr boundaryPoints);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate void TryGetDeviceIds_AsListDelegate(IntPtr @this, IntPtr deviceIds);
	}
}
