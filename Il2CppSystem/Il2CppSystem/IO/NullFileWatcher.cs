using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000186 RID: 390
	public class NullFileWatcher : Object
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x00078B00 File Offset: 0x00076D00
		// Note: this type is marked as 'beforefieldinit'.
		static NullFileWatcher()
		{
			Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "NullFileWatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr);
			NullFileWatcher.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, "instance");
			NullFileWatcher.NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, 100667026);
			NullFileWatcher.NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, 100667027);
			NullFileWatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, 100667028);
			NullFileWatcher.NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, 100667029);
			NullFileWatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr, 100667030);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00078BA8 File Offset: 0x00076DA8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartDispatching(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullFileWatcher.NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00078BEC File Offset: 0x00076DEC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopDispatching(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullFileWatcher.NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00078C30 File Offset: 0x00076E30
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullFileWatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00078C74 File Offset: 0x00076E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470041, XrefRangeEnd = 470049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetInstance(out IFileWatcher watcher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NullFileWatcher.NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				watcher = ((intPtr4 == 0) ? null : new IFileWatcher(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00078CC8 File Offset: 0x00076EC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullFileWatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullFileWatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullFileWatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0000A4C0 File Offset: 0x000086C0
		public NullFileWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00078D04 File Offset: 0x00076F04
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000A4C9 File Offset: 0x000086C9
		public unsafe static IFileWatcher instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullFileWatcher.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFileWatcher>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullFileWatcher.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
