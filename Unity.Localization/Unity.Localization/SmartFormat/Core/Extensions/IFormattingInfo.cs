using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	// Token: 0x0200008B RID: 139
	public class IFormattingInfo : Il2CppObjectBase
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00022F78 File Offset: 0x00021178
		// Note: this type is marked as 'beforefieldinit'.
		static IFormattingInfo()
		{
			Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Extensions", "IFormattingInfo");
			IFormattingInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664525);
			IFormattingInfo.NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664526);
			IFormattingInfo.NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664527);
			IFormattingInfo.NativeMethodInfoPtr_get_Alignment_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664528);
			IFormattingInfo.NativeMethodInfoPtr_get_FormatterOptions_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664529);
			IFormattingInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664530);
			IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664531);
			IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664532);
			IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664533);
			IFormattingInfo.NativeMethodInfoPtr_FormattingException_Public_Abstract_Virtual_New_FormattingException_String_FormatItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattingInfo>.NativeClassPtr, 100664534);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00023068 File Offset: 0x00021268
		public unsafe virtual Object CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000230B4 File Offset: 0x000212B4
		public unsafe virtual Format Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_Format_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00023100 File Offset: 0x00021300
		public unsafe virtual Placeholder Placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0002314C File Offset: 0x0002134C
		public unsafe virtual int Alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_Alignment_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00023194 File Offset: 0x00021394
		public unsafe virtual string FormatterOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_FormatterOptions_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000231D8 File Offset: 0x000213D8
		public unsafe virtual FormatDetails FormatDetails
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr3) : null;
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00023224 File Offset: 0x00021424
		[CallerCount(0)]
		public unsafe virtual void Write(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00023274 File Offset: 0x00021474
		[CallerCount(0)]
		public unsafe virtual void Write(string text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000232E0 File Offset: 0x000214E0
		[CallerCount(0)]
		public unsafe virtual void Write(Format format, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Format_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00023340 File Offset: 0x00021540
		[CallerCount(0)]
		public unsafe virtual FormattingException FormattingException(string issue, FormatItem problemItem = null, int startIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(issue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(problemItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattingInfo.NativeMethodInfoPtr_FormattingException_Public_Abstract_Virtual_New_FormattingException_String_FormatItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingException>(intPtr3) : null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000049B6 File Offset: 0x00002BB6
		public IFormattingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_Format_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_Abstract_Virtual_New_get_Placeholder_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatterOptions_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatDetails_Public_Abstract_Virtual_New_get_FormatDetails_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Format_Object_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_FormattingException_Public_Abstract_Virtual_New_FormattingException_String_FormatItem_Int32_0;
	}
}
