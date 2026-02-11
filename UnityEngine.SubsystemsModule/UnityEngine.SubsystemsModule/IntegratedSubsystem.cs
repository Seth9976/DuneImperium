using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class IntegratedSubsystem : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002628 File Offset: 0x00000828
		// Note: this type is marked as 'beforefieldinit'.
		static IntegratedSubsystem()
		{
			Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr);
			IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, "m_Ptr");
			IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, "m_SubsystemDescriptor");
			IntegratedSubsystem.NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663297);
			IntegratedSubsystem.NativeMethodInfoPtr_get_running_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663298);
			IntegratedSubsystem.NativeMethodInfoPtr_get_valid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663299);
			IntegratedSubsystem.NativeMethodInfoPtr_IsRunning_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663300);
			IntegratedSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663301);
			IntegratedSubsystem.StartDelegateField = IL2CPP.ResolveICall<IntegratedSubsystem.StartDelegate>("UnityEngine.IntegratedSubsystem::Start");
			IntegratedSubsystem.StopDelegateField = IL2CPP.ResolveICall<IntegratedSubsystem.StopDelegate>("UnityEngine.IntegratedSubsystem::Stop");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002704 File Offset: 0x00000904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270139, XrefRangeEnd = 1270141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(IntegratedSubsystem subsystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subsystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002748 File Offset: 0x00000948
		public unsafe virtual bool running
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1270142, RefRangeEnd = 1270144, XrefRangeStart = 1270141, XrefRangeEnd = 1270142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr_get_running_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002784 File Offset: 0x00000984
		public unsafe bool valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 948145, RefRangeEnd = 948147, XrefRangeStart = 948145, XrefRangeEnd = 948147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr_get_valid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000027C0 File Offset: 0x000009C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270144, XrefRangeEnd = 1270146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRunning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr_IsRunning_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000027FC File Offset: 0x000009FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		public IntegratedSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002860 File Offset: 0x00000A60
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe ISubsystemDescriptor m_SubsystemDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISubsystemDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002093 File Offset: 0x00000293
		public void Start()
		{
			IntegratedSubsystem.StartDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020A5 File Offset: 0x000002A5
		public void Stop()
		{
			IntegratedSubsystem.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002890 File Offset: 0x00000A90
		public void Destroy()
		{
			IntPtr ptr = this.m_Ptr;
			SubsystemManager.RemoveIntegratedSubsystemByPtr(this.m_Ptr);
			SubsystemBindings.DestroySubsystem(ptr);
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_SubsystemDescriptor;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_running_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_valid_Internal_get_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_IsRunning_Internal_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntegratedSubsystem.StartDelegate StartDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly IntegratedSubsystem.StopDelegate StopDelegateField;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600009B RID: 155
		private delegate void StartDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600009D RID: 157
		private delegate void StopDelegate(IntPtr @this);
	}
}
