using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000267 RID: 615
	[StructLayout(2)]
	public struct PlayableOutputHandle
	{
		// Token: 0x06002A81 RID: 10881 RVA: 0x000ADABC File Offset: 0x000ABCBC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputHandle()
		{
			Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
			PlayableOutputHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Handle");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Version");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Null");
			PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668574);
			PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668575);
			PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668576);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668577);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668578);
			PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100668579);
			PlayableOutputHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull_Injected");
			PlayableOutputHandle.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsValid_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsValid_Injected");
			PlayableOutputHandle.GetPlayableOutputType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetPlayableOutputType_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetPlayableOutputType_Injected");
			PlayableOutputHandle.GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
			PlayableOutputHandle.SetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetReferenceObject_Injected");
			PlayableOutputHandle.GetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected");
			PlayableOutputHandle.SetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetUserData_Injected");
			PlayableOutputHandle.GetSourcePlayable_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetSourcePlayable_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetSourcePlayable_Injected");
			PlayableOutputHandle.SetSourcePlayable_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetSourcePlayable_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetSourcePlayable_Injected");
			PlayableOutputHandle.GetSourceOutputPort_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetSourceOutputPort_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetSourceOutputPort_Injected");
			PlayableOutputHandle.GetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight_Injected");
			PlayableOutputHandle.SetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetWeight_Injected");
			PlayableOutputHandle.PushNotification_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.PushNotification_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::PushNotification_Injected");
			PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers_Injected");
			PlayableOutputHandle.AddNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.AddNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::AddNotificationReceiver_Injected");
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver_Injected");
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000ADC90 File Offset: 0x000ABE90
		public unsafe static PlayableOutputHandle Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685873, XrefRangeEnd = 685877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000ADCC0 File Offset: 0x000ABEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000ADCF0 File Offset: 0x000ABEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685877, XrefRangeEnd = 685881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x000ADD3C File Offset: 0x000ABF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685881, XrefRangeEnd = 685890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000ADD80 File Offset: 0x000ABF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685890, XrefRangeEnd = 685894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutputHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000ADDC0 File Offset: 0x000ABFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00010988 File Offset: 0x0000EB88
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000ADE0C File Offset: 0x000AC00C
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0001099A File Offset: 0x0000EB9A
		public unsafe static PlayableOutputHandle m_Null
		{
			get
			{
				PlayableOutputHandle playableOutputHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableOutputHandle));
				return playableOutputHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x000ADE28 File Offset: 0x000AC028
		public bool IsPlayableOutputOfType<T>()
		{
			return this.GetPlayableOutputType() == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000ADE50 File Offset: 0x000AC050
		public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return !PlayableOutputHandle.CompareVersion(lhs, rhs);
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000109A8 File Offset: 0x0000EBA8
		public bool IsNull()
		{
			return PlayableOutputHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000109B0 File Offset: 0x0000EBB0
		public bool IsValid()
		{
			return PlayableOutputHandle.IsValid_Injected(ref this);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000109B8 File Offset: 0x0000EBB8
		public Type GetPlayableOutputType()
		{
			return PlayableOutputHandle.GetPlayableOutputType_Injected(ref this);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000109C0 File Offset: 0x0000EBC0
		public Object GetReferenceObject()
		{
			return PlayableOutputHandle.GetReferenceObject_Injected(ref this);
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000109C8 File Offset: 0x0000EBC8
		public void SetReferenceObject(Object target)
		{
			PlayableOutputHandle.SetReferenceObject_Injected(ref this, target);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000109D1 File Offset: 0x0000EBD1
		public Object GetUserData()
		{
			return PlayableOutputHandle.GetUserData_Injected(ref this);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000109D9 File Offset: 0x0000EBD9
		public void SetUserData(Object target)
		{
			PlayableOutputHandle.SetUserData_Injected(ref this, target);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000ADE6C File Offset: 0x000AC06C
		public PlayableHandle GetSourcePlayable()
		{
			PlayableHandle playableHandle;
			PlayableOutputHandle.GetSourcePlayable_Injected(ref this, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000109E2 File Offset: 0x0000EBE2
		public void SetSourcePlayable(PlayableHandle target, int port)
		{
			PlayableOutputHandle.SetSourcePlayable_Injected(ref this, ref target, port);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000109ED File Offset: 0x0000EBED
		public int GetSourceOutputPort()
		{
			return PlayableOutputHandle.GetSourceOutputPort_Injected(ref this);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000109F5 File Offset: 0x0000EBF5
		public float GetWeight()
		{
			return PlayableOutputHandle.GetWeight_Injected(ref this);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000109FD File Offset: 0x0000EBFD
		public void SetWeight(float weight)
		{
			PlayableOutputHandle.SetWeight_Injected(ref this, weight);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00010A06 File Offset: 0x0000EC06
		public void PushNotification(PlayableHandle origin, INotification notification, Object context)
		{
			PlayableOutputHandle.PushNotification_Injected(ref this, ref origin, notification, context);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00010A12 File Offset: 0x0000EC12
		public Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
		{
			return PlayableOutputHandle.GetNotificationReceivers_Injected(ref this);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00010A1A File Offset: 0x0000EC1A
		public void AddNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.AddNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00010A23 File Offset: 0x0000EC23
		public void RemoveNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00010A2C File Offset: 0x0000EC2C
		public static bool IsNull_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00010A39 File Offset: 0x0000EC39
		public static bool IsValid_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsValid_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000ADE84 File Offset: 0x000AC084
		public static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetPlayableOutputType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000ADEAC File Offset: 0x000AC0AC
		public static Object GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetReferenceObject_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00010A46 File Offset: 0x0000EC46
		public static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			PlayableOutputHandle.SetReferenceObject_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000ADED4 File Offset: 0x000AC0D4
		public static Object GetUserData_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetUserData_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00010A59 File Offset: 0x0000EC59
		public static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			PlayableOutputHandle.SetUserData_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00010A6C File Offset: 0x0000EC6C
		public static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
		{
			PlayableOutputHandle.GetSourcePlayable_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00010A7A File Offset: 0x0000EC7A
		public static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port)
		{
			PlayableOutputHandle.SetSourcePlayable_InjectedDelegateField(ref _unity_self, ref target, port);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00010A89 File Offset: 0x0000EC89
		public static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetSourceOutputPort_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00010A96 File Offset: 0x0000EC96
		public static float GetWeight_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetWeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00010AA3 File Offset: 0x0000ECA3
		public static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight)
		{
			PlayableOutputHandle.SetWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00010AB1 File Offset: 0x0000ECB1
		public static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, Object context)
		{
			PlayableOutputHandle.PushNotification_InjectedDelegateField(ref _unity_self, ref origin, IL2CPP.Il2CppObjectBaseToPtr(notification), IL2CPP.Il2CppObjectBaseToPtr(context));
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000ADEFC File Offset: 0x000AC0FC
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(intPtr2) : null;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00010ACB File Offset: 0x0000ECCB
		public static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.AddNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00010ADE File Offset: 0x0000ECDE
		public static void RemoveNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x04002553 RID: 9555
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x04002554 RID: 9556
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x04002555 RID: 9557
		private static readonly PlayableOutputHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x04002556 RID: 9558
		private static readonly PlayableOutputHandle.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x04002557 RID: 9559
		private static readonly PlayableOutputHandle.GetPlayableOutputType_InjectedDelegate GetPlayableOutputType_InjectedDelegateField;

		// Token: 0x04002558 RID: 9560
		private static readonly PlayableOutputHandle.GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;

		// Token: 0x04002559 RID: 9561
		private static readonly PlayableOutputHandle.SetReferenceObject_InjectedDelegate SetReferenceObject_InjectedDelegateField;

		// Token: 0x0400255A RID: 9562
		private static readonly PlayableOutputHandle.GetUserData_InjectedDelegate GetUserData_InjectedDelegateField;

		// Token: 0x0400255B RID: 9563
		private static readonly PlayableOutputHandle.SetUserData_InjectedDelegate SetUserData_InjectedDelegateField;

		// Token: 0x0400255C RID: 9564
		private static readonly PlayableOutputHandle.GetSourcePlayable_InjectedDelegate GetSourcePlayable_InjectedDelegateField;

		// Token: 0x0400255D RID: 9565
		private static readonly PlayableOutputHandle.SetSourcePlayable_InjectedDelegate SetSourcePlayable_InjectedDelegateField;

		// Token: 0x0400255E RID: 9566
		private static readonly PlayableOutputHandle.GetSourceOutputPort_InjectedDelegate GetSourceOutputPort_InjectedDelegateField;

		// Token: 0x0400255F RID: 9567
		private static readonly PlayableOutputHandle.GetWeight_InjectedDelegate GetWeight_InjectedDelegateField;

		// Token: 0x04002560 RID: 9568
		private static readonly PlayableOutputHandle.SetWeight_InjectedDelegate SetWeight_InjectedDelegateField;

		// Token: 0x04002561 RID: 9569
		private static readonly PlayableOutputHandle.PushNotification_InjectedDelegate PushNotification_InjectedDelegateField;

		// Token: 0x04002562 RID: 9570
		private static readonly PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate GetNotificationReceivers_InjectedDelegateField;

		// Token: 0x04002563 RID: 9571
		private static readonly PlayableOutputHandle.AddNotificationReceiver_InjectedDelegate AddNotificationReceiver_InjectedDelegateField;

		// Token: 0x04002564 RID: 9572
		private static readonly PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate RemoveNotificationReceiver_InjectedDelegateField;

		// Token: 0x02000A4D RID: 2637
		// (Invoke) Token: 0x06003DB7 RID: 15799
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A4E RID: 2638
		// (Invoke) Token: 0x06003DB9 RID: 15801
		private delegate bool IsValid_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A4F RID: 2639
		// (Invoke) Token: 0x06003DBB RID: 15803
		private delegate IntPtr GetPlayableOutputType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A50 RID: 2640
		// (Invoke) Token: 0x06003DBD RID: 15805
		private delegate IntPtr GetReferenceObject_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A51 RID: 2641
		// (Invoke) Token: 0x06003DBF RID: 15807
		private delegate void SetReferenceObject_InjectedDelegate(IntPtr _unity_self, IntPtr target);

		// Token: 0x02000A52 RID: 2642
		// (Invoke) Token: 0x06003DC1 RID: 15809
		private delegate IntPtr GetUserData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A53 RID: 2643
		// (Invoke) Token: 0x06003DC3 RID: 15811
		private delegate void SetUserData_InjectedDelegate(IntPtr _unity_self, IntPtr target);

		// Token: 0x02000A54 RID: 2644
		// (Invoke) Token: 0x06003DC5 RID: 15813
		private delegate void GetSourcePlayable_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000A55 RID: 2645
		// (Invoke) Token: 0x06003DC7 RID: 15815
		private delegate void SetSourcePlayable_InjectedDelegate(IntPtr _unity_self, IntPtr target, int port);

		// Token: 0x02000A56 RID: 2646
		// (Invoke) Token: 0x06003DC9 RID: 15817
		private delegate int GetSourceOutputPort_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A57 RID: 2647
		// (Invoke) Token: 0x06003DCB RID: 15819
		private delegate float GetWeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A58 RID: 2648
		// (Invoke) Token: 0x06003DCD RID: 15821
		private delegate void SetWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x02000A59 RID: 2649
		// (Invoke) Token: 0x06003DCF RID: 15823
		private delegate void PushNotification_InjectedDelegate(IntPtr _unity_self, IntPtr origin, IntPtr notification, IntPtr context);

		// Token: 0x02000A5A RID: 2650
		// (Invoke) Token: 0x06003DD1 RID: 15825
		private delegate IntPtr GetNotificationReceivers_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A5B RID: 2651
		// (Invoke) Token: 0x06003DD3 RID: 15827
		private delegate void AddNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);

		// Token: 0x02000A5C RID: 2652
		// (Invoke) Token: 0x06003DD5 RID: 15829
		private delegate void RemoveNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);
	}
}
