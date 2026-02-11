using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002EF RID: 751
	public class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x06002E90 RID: 11920 RVA: 0x000F0580 File Offset: 0x000EE780
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodCallMessage()
		{
			Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodCallMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr);
			CADMethodCallMessage.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, "_uri");
			CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670704);
			CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670705);
			CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670706);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670707);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670708);
			CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100670709);
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x000F063C File Offset: 0x000EE83C
		public unsafe string Uri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000F0674 File Offset: 0x000EE874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382811, XrefRangeEnd = 1382818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodCallMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodCallMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000F06B8 File Offset: 0x000EE8B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382850, RefRangeEnd = 1382852, XrefRangeStart = 1382818, XrefRangeEnd = 1382850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodCallMessage(IMethodCallMessage callMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000F0704 File Offset: 0x000EE904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382852, XrefRangeEnd = 1382875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000F0744 File Offset: 0x000EE944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382875, XrefRangeEnd = 1382876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000F0794 File Offset: 0x000EE994
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x0000FD4A File Offset: 0x0000DF4A
		public CADMethodCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000F07D0 File Offset: 0x000EE9D0
		// (set) Token: 0x06002E99 RID: 11929 RVA: 0x0000FD53 File Offset: 0x0000DF53
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Internal_get_String_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
