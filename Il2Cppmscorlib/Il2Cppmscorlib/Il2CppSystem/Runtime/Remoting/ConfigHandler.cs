using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Xml;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200029B RID: 667
	public class ConfigHandler : Object
	{
		// Token: 0x06002AB9 RID: 10937 RVA: 0x000E27D0 File Offset: 0x000E09D0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigHandler()
		{
			Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ConfigHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr);
			ConfigHandler.NativeFieldInfoPtr_typeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "typeEntries");
			ConfigHandler.NativeFieldInfoPtr_channelInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "channelInstances");
			ConfigHandler.NativeFieldInfoPtr_currentChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentChannel");
			ConfigHandler.NativeFieldInfoPtr_currentProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentProviderData");
			ConfigHandler.NativeFieldInfoPtr_currentClientUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentClientUrl");
			ConfigHandler.NativeFieldInfoPtr_appName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "appName");
			ConfigHandler.NativeFieldInfoPtr_currentXmlPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentXmlPath");
			ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "onlyDelayedChannels");
			ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670236);
			ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670237);
			ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670238);
			ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670239);
			ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670240);
			ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670241);
			ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670242);
			ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670243);
			ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670244);
			ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670245);
			ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670246);
			ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670247);
			ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670248);
			ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670249);
			ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670250);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670251);
			ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670252);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670253);
			ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670254);
			ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670255);
			ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670256);
			ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670257);
			ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670258);
			ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100670259);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000E2A80 File Offset: 0x000E0C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377473, XrefRangeEnd = 1377487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigHandler(bool onlyDelayedChannels)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyDelayedChannels;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000E2AC8 File Offset: 0x000E0CC8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1377489, RefRangeEnd = 1377500, XrefRangeStart = 1377487, XrefRangeEnd = 1377489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidatePath(string element, [Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000E2B2C File Offset: 0x000E0D2C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1377506, RefRangeEnd = 1377515, XrefRangeStart = 1377500, XrefRangeEnd = 1377506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000E2B7C File Offset: 0x000E0D7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000E2BC0 File Offset: 0x000E0DC0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000E2C14 File Offset: 0x000E0E14
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIgnorableWhitespace(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000E2C58 File Offset: 0x000E0E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377515, XrefRangeEnd = 1377523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000E2CAC File Offset: 0x000E0EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377746, RefRangeEnd = 1377747, XrefRangeStart = 1377523, XrefRangeEnd = 1377746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000E2D00 File Offset: 0x000E0F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377747, XrefRangeEnd = 1377751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000E2D44 File Offset: 0x000E0F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377751, XrefRangeEnd = 1377777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000E2D98 File Offset: 0x000E0F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377823, RefRangeEnd = 1377824, XrefRangeStart = 1377777, XrefRangeEnd = 1377823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadLifetine(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000E2DDC File Offset: 0x000E0FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1377858, RefRangeEnd = 1377862, XrefRangeStart = 1377824, XrefRangeEnd = 1377858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ParseTime(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000E2E2C File Offset: 0x000E102C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377935, RefRangeEnd = 1377936, XrefRangeStart = 1377862, XrefRangeEnd = 1377935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000E2E7C File Offset: 0x000E107C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1377988, RefRangeEnd = 1377992, XrefRangeStart = 1377936, XrefRangeEnd = 1377988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProviderData>(intPtr3) : null;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000E2EEC File Offset: 0x000E10EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378012, RefRangeEnd = 1378013, XrefRangeStart = 1377992, XrefRangeEnd = 1378012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000E2F30 File Offset: 0x000E1130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378029, RefRangeEnd = 1378030, XrefRangeStart = 1378013, XrefRangeEnd = 1378029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000E2F74 File Offset: 0x000E1174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378050, RefRangeEnd = 1378051, XrefRangeStart = 1378030, XrefRangeEnd = 1378050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000E2FB8 File Offset: 0x000E11B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378081, RefRangeEnd = 1378082, XrefRangeStart = 1378051, XrefRangeEnd = 1378081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000E2FFC File Offset: 0x000E11FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378104, RefRangeEnd = 1378105, XrefRangeStart = 1378082, XrefRangeEnd = 1378104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000E304C File Offset: 0x000E124C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378134, RefRangeEnd = 1378135, XrefRangeStart = 1378105, XrefRangeEnd = 1378134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPreload(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000E3090 File Offset: 0x000E1290
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1378141, RefRangeEnd = 1378150, XrefRangeStart = 1378135, XrefRangeEnd = 1378141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000E30EC File Offset: 0x000E12EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1378157, RefRangeEnd = 1378161, XrefRangeStart = 1378150, XrefRangeEnd = 1378157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ExtractAssembly(ref string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(type);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				type = IL2CPP.Il2CppStringToManaged(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000E3144 File Offset: 0x000E1344
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChars(string ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000E3188 File Offset: 0x000E1388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378161, XrefRangeEnd = 1378176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0000E36A File Offset: 0x0000C56A
		public void ValidatePath(string element, params string[] paths)
		{
			this.ValidatePath(element, new Il2CppStringArray(paths));
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0000E379 File Offset: 0x0000C579
		public ConfigHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000E31CC File Offset: 0x000E13CC
		// (set) Token: 0x06002AD5 RID: 10965 RVA: 0x0000E382 File Offset: 0x0000C582
		public unsafe ArrayList typeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x000E31FC File Offset: 0x000E13FC
		// (set) Token: 0x06002AD7 RID: 10967 RVA: 0x0000E3A1 File Offset: 0x0000C5A1
		public unsafe ArrayList channelInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x000E322C File Offset: 0x000E142C
		// (set) Token: 0x06002AD9 RID: 10969 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		public unsafe ChannelData currentChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000E325C File Offset: 0x000E145C
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x0000E3DF File Offset: 0x0000C5DF
		public unsafe Stack currentProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000E328C File Offset: 0x000E148C
		// (set) Token: 0x06002ADD RID: 10973 RVA: 0x0000E3FE File Offset: 0x0000C5FE
		public unsafe string currentClientUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000E32B4 File Offset: 0x000E14B4
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x0000E41D File Offset: 0x0000C61D
		public unsafe string appName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x000E32DC File Offset: 0x000E14DC
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x0000E43C File Offset: 0x0000C63C
		public unsafe string currentXmlPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000E3304 File Offset: 0x000E1504
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x0000E45B File Offset: 0x0000C65B
		public unsafe bool onlyDelayedChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels)) = value;
			}
		}

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeFieldInfoPtr_typeEntries;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeFieldInfoPtr_channelInstances;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeFieldInfoPtr_currentChannel;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeFieldInfoPtr_currentProviderData;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeFieldInfoPtr_currentClientUrl;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeFieldInfoPtr_appName;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeFieldInfoPtr_currentXmlPath;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeFieldInfoPtr_onlyDelayedChannels;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;
	}
}
