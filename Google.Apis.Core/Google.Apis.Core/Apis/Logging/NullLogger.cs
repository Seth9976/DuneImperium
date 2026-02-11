using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Google.Apis.Logging
{
	// Token: 0x0200001D RID: 29
	public class NullLogger : Object
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00008A2C File Offset: 0x00006C2C
		// Note: this type is marked as 'beforefieldinit'.
		static NullLogger()
		{
			Il2CppClassPointerStore<NullLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Logging", "NullLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullLogger>.NativeClassPtr);
			NullLogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663471);
			NullLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663472);
			NullLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663473);
			NullLogger.NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663474);
			NullLogger.NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663475);
			NullLogger.NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663476);
			NullLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663477);
			NullLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663478);
			NullLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullLogger>.NativeClassPtr, 100663479);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00008B10 File Offset: 0x00006D10
		public unsafe virtual bool IsDebugEnabled
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00008B4C File Offset: 0x00006D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211132, XrefRangeEnd = 1211136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger ForType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008B9C File Offset: 0x00006D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211136, XrefRangeEnd = 1211140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger ForType<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.MethodInfoStoreGeneric_ForType_Public_Virtual_Final_New_ILogger_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008BDC File Offset: 0x00006DDC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Info(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008C40 File Offset: 0x00006E40
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Warning(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00008CA4 File Offset: 0x00006EA4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Debug(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008D08 File Offset: 0x00006F08
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Error(Exception exception, string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008D7C File Offset: 0x00006F7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Error(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008DE0 File Offset: 0x00006FE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullLogger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullLogger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002715 File Offset: 0x00000915
		public virtual void Info(string message, params Object[] formatArgs)
		{
			this.Info(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002724 File Offset: 0x00000924
		public virtual void Warning(string message, params Object[] formatArgs)
		{
			this.Warning(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002733 File Offset: 0x00000933
		public virtual void Debug(string message, params Object[] formatArgs)
		{
			this.Debug(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002742 File Offset: 0x00000942
		public virtual void Error(Exception exception, string message, params Object[] formatArgs)
		{
			this.Error(exception, message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002752 File Offset: 0x00000952
		public virtual void Error(string message, params Object[] formatArgs)
		{
			this.Error(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002761 File Offset: 0x00000961
		public NullLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000051 RID: 81
		private sealed class MethodInfoStoreGeneric_ForType_Public_Virtual_Final_New_ILogger_0<T>
		{
			// Token: 0x040001FA RID: 506
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0, Il2CppClassPointerStore<NullLogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
