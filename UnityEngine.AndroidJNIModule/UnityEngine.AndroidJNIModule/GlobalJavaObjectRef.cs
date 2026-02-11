using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class GlobalJavaObjectRef : Object
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002EEC File Offset: 0x000010EC
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalJavaObjectRef()
		{
			Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "GlobalJavaObjectRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr);
			GlobalJavaObjectRef.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr, "m_disposed");
			GlobalJavaObjectRef.NativeFieldInfoPtr_m_jobject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr, "m_jobject");
			GlobalJavaObjectRef.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr, 100663302);
			GlobalJavaObjectRef.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_GlobalJavaObjectRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr, 100663303);
			GlobalJavaObjectRef.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalJavaObjectRef>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002F80 File Offset: 0x00001180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227296, XrefRangeEnd = 1227303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GlobalJavaObjectRef.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002FBC File Offset: 0x000011BC
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 393222, RefRangeEnd = 393273, XrefRangeStart = 393222, XrefRangeEnd = 393273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator IntPtr(GlobalJavaObjectRef obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalJavaObjectRef.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_GlobalJavaObjectRef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003000 File Offset: 0x00001200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227303, XrefRangeEnd = 1227307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalJavaObjectRef.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020A8 File Offset: 0x000002A8
		public GlobalJavaObjectRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003034 File Offset: 0x00001234
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020B1 File Offset: 0x000002B1
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalJavaObjectRef.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalJavaObjectRef.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000020CC File Offset: 0x000002CC
		public unsafe IntPtr m_jobject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalJavaObjectRef.NativeFieldInfoPtr_m_jobject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalJavaObjectRef.NativeFieldInfoPtr_m_jobject)) = value;
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_jobject;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_GlobalJavaObjectRef_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}
