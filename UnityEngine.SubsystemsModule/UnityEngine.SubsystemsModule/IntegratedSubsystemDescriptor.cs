using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class IntegratedSubsystemDescriptor : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002980 File Offset: 0x00000B80
		// Note: this type is marked as 'beforefieldinit'.
		static IntegratedSubsystemDescriptor()
		{
			Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr);
			IntegratedSubsystemDescriptor.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, "m_Ptr");
			IntegratedSubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, 100663303);
			IntegratedSubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr, 100663304);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000029EC File Offset: 0x00000BEC
		public unsafe virtual string id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270146, XrefRangeEnd = 1270148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002A24 File Offset: 0x00000C24
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020D5 File Offset: 0x000002D5
		public IntegratedSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020DE File Offset: 0x000002DE
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystemDescriptor.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystemDescriptor.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020F9 File Offset: 0x000002F9
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002101 File Offset: 0x00000301
		public IntPtr UnityEngine.ISubsystemDescriptorImpl.ptr
		{
			get
			{
				return this.m_Ptr;
			}
			set
			{
				this.m_Ptr = value;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000210A File Offset: 0x0000030A
		public ISubsystem UnityEngine.ISubsystemDescriptor.Create()
		{
			return this.CreateImpl();
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
